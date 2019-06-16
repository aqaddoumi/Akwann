using System.Collections.Generic;
using Entitas;

public sealed class LoadAssetByAssetPathSystem : ReactiveSystem<CoreEntity>, IInitializeSystem {
    private readonly Contexts _contexts;
    private  IViewService _viewService;
    
    public LoadAssetByAssetPathSystem(Contexts contexts) : base(contexts.core) {
        _contexts = contexts;
    }

    public void Initialize() {
        _viewService = _contexts.service.viewService.value;
    }
    
    protected override ICollector<CoreEntity> GetTrigger(IContext<CoreEntity> context) {
        return context.CreateCollector(CoreMatcher.AssetPath.Added());
    }
    
    protected override bool Filter(CoreEntity entity) {
        return entity.hasAssetPath && !entity.isAssetLoaded;
    }
    
    protected override void Execute(List<CoreEntity> entities) {
        foreach (var e in entities) {
            _viewService.LoadAsset(e, e.assetPath.value);
            e.isAssetLoaded = true;
        }
    }
}