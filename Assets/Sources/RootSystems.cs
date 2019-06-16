using Entitas;

public class RootSystems : Feature  {
    public RootSystems(Contexts contexts, Services services) : base("Root Systems") {
        Add(new ServiceSystems(contexts, services));

        Add(new FactorySystems(contexts));
        
        Add(new CoreEventSystems(contexts));

        Add(new AssetSystems(contexts));

        Add(new MotionSystems(contexts));

        Add(new DestroySystems(contexts));
    }	
}