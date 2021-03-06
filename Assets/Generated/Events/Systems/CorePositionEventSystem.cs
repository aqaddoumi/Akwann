//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class CorePositionEventSystem : Entitas.ReactiveSystem<CoreEntity> {

    readonly System.Collections.Generic.List<ICorePositionListener> _listenerBuffer;

    public CorePositionEventSystem(Contexts contexts) : base(contexts.core) {
        _listenerBuffer = new System.Collections.Generic.List<ICorePositionListener>();
    }

    protected override Entitas.ICollector<CoreEntity> GetTrigger(Entitas.IContext<CoreEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(CoreMatcher.Position)
        );
    }

    protected override bool Filter(CoreEntity entity) {
        return entity.hasPosition && entity.hasCorePositionListener;
    }

    protected override void Execute(System.Collections.Generic.List<CoreEntity> entities) {
        foreach (var e in entities) {
            var component = e.position;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.corePositionListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnPosition(e, component.value);
            }
        }
    }
}
