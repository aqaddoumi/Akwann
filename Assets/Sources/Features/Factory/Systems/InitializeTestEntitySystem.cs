using Entitas;
using UnityEngine;

public class InitializeTestEntitySystem : IInitializeSystem  {
	private Contexts _contexts;

    public InitializeTestEntitySystem(Contexts contexts) {
    	_contexts = contexts;
    }

	public void Initialize() {
		var e = _contexts.core.CreateEntity();
		e.AddAssetPath("Cube");
		e.AddPosition(Vector3.zero);
		e.AddVelocity(Vector3.up);
	}		
}