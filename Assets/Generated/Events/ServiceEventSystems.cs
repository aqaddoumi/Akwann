//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class ServiceEventSystems : Feature {

    public ServiceEventSystems(Contexts contexts) {
        Add(new ServiceDestroyedEventSystem(contexts)); // priority: 0
        Add(new ServicePositionEventSystem(contexts)); // priority: 0
    }
}
