using Entitas;

public sealed class InitializeViewServiceSystem : IInitializeSystem {
    
    private readonly ServiceContext _serviceContext;
    private readonly IViewService _viewService;
    
    public InitializeViewServiceSystem(Contexts contexts, IViewService service) {
        _serviceContext = contexts.service;
        _viewService = service;
    }
    
    public void Initialize() {
        _serviceContext.ReplaceViewService(_viewService);
    }
}