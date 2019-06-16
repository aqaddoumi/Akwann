//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class ServiceDestroyedEventSystem : Entitas.ReactiveSystem<ServiceEntity> {

    readonly System.Collections.Generic.List<IServiceDestroyedListener> _listenerBuffer;

    public ServiceDestroyedEventSystem(Contexts contexts) : base(contexts.service) {
        _listenerBuffer = new System.Collections.Generic.List<IServiceDestroyedListener>();
    }

    protected override Entitas.ICollector<ServiceEntity> GetTrigger(Entitas.IContext<ServiceEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(ServiceMatcher.Destroyed)
        );
    }

    protected override bool Filter(ServiceEntity entity) {
        return entity.isDestroyed && entity.hasServiceDestroyedListener;
    }

    protected override void Execute(System.Collections.Generic.List<ServiceEntity> entities) {
        foreach (var e in entities) {
            
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.serviceDestroyedListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnDestroyed(e);
            }
        }
    }
}