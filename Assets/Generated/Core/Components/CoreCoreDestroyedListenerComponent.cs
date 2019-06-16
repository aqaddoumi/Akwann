//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class CoreEntity {

    public CoreDestroyedListenerComponent coreDestroyedListener { get { return (CoreDestroyedListenerComponent)GetComponent(CoreComponentsLookup.CoreDestroyedListener); } }
    public bool hasCoreDestroyedListener { get { return HasComponent(CoreComponentsLookup.CoreDestroyedListener); } }

    public void AddCoreDestroyedListener(System.Collections.Generic.List<ICoreDestroyedListener> newValue) {
        var index = CoreComponentsLookup.CoreDestroyedListener;
        var component = (CoreDestroyedListenerComponent)CreateComponent(index, typeof(CoreDestroyedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCoreDestroyedListener(System.Collections.Generic.List<ICoreDestroyedListener> newValue) {
        var index = CoreComponentsLookup.CoreDestroyedListener;
        var component = (CoreDestroyedListenerComponent)CreateComponent(index, typeof(CoreDestroyedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCoreDestroyedListener() {
        RemoveComponent(CoreComponentsLookup.CoreDestroyedListener);
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
public sealed partial class CoreMatcher {

    static Entitas.IMatcher<CoreEntity> _matcherCoreDestroyedListener;

    public static Entitas.IMatcher<CoreEntity> CoreDestroyedListener {
        get {
            if (_matcherCoreDestroyedListener == null) {
                var matcher = (Entitas.Matcher<CoreEntity>)Entitas.Matcher<CoreEntity>.AllOf(CoreComponentsLookup.CoreDestroyedListener);
                matcher.componentNames = CoreComponentsLookup.componentNames;
                _matcherCoreDestroyedListener = matcher;
            }

            return _matcherCoreDestroyedListener;
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
public partial class CoreEntity {

    public void AddCoreDestroyedListener(ICoreDestroyedListener value) {
        var listeners = hasCoreDestroyedListener
            ? coreDestroyedListener.value
            : new System.Collections.Generic.List<ICoreDestroyedListener>();
        listeners.Add(value);
        ReplaceCoreDestroyedListener(listeners);
    }

    public void RemoveCoreDestroyedListener(ICoreDestroyedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = coreDestroyedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveCoreDestroyedListener();
        } else {
            ReplaceCoreDestroyedListener(listeners);
        }
    }
}