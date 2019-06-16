//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServiceEntity {

    public PositionComponent position { get { return (PositionComponent)GetComponent(ServiceComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(ServiceComponentsLookup.Position); } }

    public void AddPosition(UnityEngine.Vector3 newValue) {
        var index = ServiceComponentsLookup.Position;
        var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePosition(UnityEngine.Vector3 newValue) {
        var index = ServiceComponentsLookup.Position;
        var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(ServiceComponentsLookup.Position);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ServiceEntity : IPositionEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ServiceMatcher {

    static Entitas.IMatcher<ServiceEntity> _matcherPosition;

    public static Entitas.IMatcher<ServiceEntity> Position {
        get {
            if (_matcherPosition == null) {
                var matcher = (Entitas.Matcher<ServiceEntity>)Entitas.Matcher<ServiceEntity>.AllOf(ServiceComponentsLookup.Position);
                matcher.componentNames = ServiceComponentsLookup.componentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}