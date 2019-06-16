//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServiceEntity {

    public ServicePositionListenerComponent servicePositionListener { get { return (ServicePositionListenerComponent)GetComponent(ServiceComponentsLookup.ServicePositionListener); } }
    public bool hasServicePositionListener { get { return HasComponent(ServiceComponentsLookup.ServicePositionListener); } }

    public void AddServicePositionListener(System.Collections.Generic.List<IServicePositionListener> newValue) {
        var index = ServiceComponentsLookup.ServicePositionListener;
        var component = (ServicePositionListenerComponent)CreateComponent(index, typeof(ServicePositionListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceServicePositionListener(System.Collections.Generic.List<IServicePositionListener> newValue) {
        var index = ServiceComponentsLookup.ServicePositionListener;
        var component = (ServicePositionListenerComponent)CreateComponent(index, typeof(ServicePositionListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveServicePositionListener() {
        RemoveComponent(ServiceComponentsLookup.ServicePositionListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServiceMatcher {

    static Entitas.IMatcher<ServiceEntity> _matcherServicePositionListener;

    public static Entitas.IMatcher<ServiceEntity> ServicePositionListener {
        get {
            if (_matcherServicePositionListener == null) {
                var matcher = (Entitas.Matcher<ServiceEntity>)Entitas.Matcher<ServiceEntity>.AllOf(ServiceComponentsLookup.ServicePositionListener);
                matcher.componentNames = ServiceComponentsLookup.componentNames;
                _matcherServicePositionListener = matcher;
            }

            return _matcherServicePositionListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServiceEntity {

    public void AddServicePositionListener(IServicePositionListener value) {
        var listeners = hasServicePositionListener
            ? servicePositionListener.value
            : new System.Collections.Generic.List<IServicePositionListener>();
        listeners.Add(value);
        ReplaceServicePositionListener(listeners);
    }

    public void RemoveServicePositionListener(IServicePositionListener value, bool removeComponentWhenEmpty = true) {
        var listeners = servicePositionListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveServicePositionListener();
        } else {
            ReplaceServicePositionListener(listeners);
        }
    }
}
