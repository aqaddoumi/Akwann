//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class ServicePositionEventSystem : Entitas.ReactiveSystem<ServiceEntity> {

    readonly System.Collections.Generic.List<IServicePositionListener> _listenerBuffer;

    public ServicePositionEventSystem(Contexts contexts) : base(contexts.service) {
        _listenerBuffer = new System.Collections.Generic.List<IServicePositionListener>();
    }

    protected override Entitas.ICollector<ServiceEntity> GetTrigger(Entitas.IContext<ServiceEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(ServiceMatcher.Position)
        );
    }

    protected override bool Filter(ServiceEntity entity) {
        return entity.hasPosition && entity.hasServicePositionListener;
    }

    protected override void Execute(System.Collections.Generic.List<ServiceEntity> entities) {
        foreach (var e in entities) {
            var component = e.position;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.servicePositionListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnPosition(e, component.value);
            }
        }
    }
}
