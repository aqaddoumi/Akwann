public sealed class ServiceSystems : Feature {
    
    public ServiceSystems(Contexts contexts, Services services) : base("Service Systems") {
        Add(new InitializeViewServiceSystem(contexts, services.View));
    }
}