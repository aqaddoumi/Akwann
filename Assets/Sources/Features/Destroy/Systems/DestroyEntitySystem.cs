using Entitas;
using System.Collections.Generic;
using UnityEngine;

public interface IDestroy : IEntity, IDestroyedEntity {}

public partial class CoreEntity : IDestroy {}

public class DestroyEntitySystem : MultiReactiveSystem<IDestroy, Contexts> {
    public DestroyEntitySystem(Contexts contexts) : base(contexts) {
    }

    protected override ICollector[] GetTrigger(Contexts contexts) {
        return new ICollector[] {
            contexts.core.CreateCollector(CoreMatcher.Destroyed)
        };
    }

    protected override bool Filter(IDestroy entity) {
        return entity.isDestroyed;
    }

    protected override void Execute(List<IDestroy> entities) {
        foreach (var e in entities) {
            e.Destroy();
        }
    }
}