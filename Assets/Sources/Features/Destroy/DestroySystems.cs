using Entitas;

public class DestroySystems : Feature  {
    public DestroySystems(Contexts contexts) {
        Add(new DestroyEntitySystem(contexts));
    }	
}