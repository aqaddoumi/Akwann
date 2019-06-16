using Entitas;

public class FactorySystems : Feature  {
    public FactorySystems(Contexts contexts) {
        Add(new InitializeTestEntitySystem(contexts));
    }	
}