using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour {

	private Contexts _contexts;
	private Services _rootServices;
	private RootSystems _rootSystems;
	//private RootFixedSystems _rootFixedSystems;
	
	private void Awake () {	
		_contexts = Contexts.sharedInstance;
		
		_rootServices = new RootServices();
		_rootSystems = new RootSystems(_contexts, _rootServices);
		//_rootFixedSystems = new RootFixedSystems(_contexts);
	
		AddEntitiesIds();
		
		_rootSystems.Initialize();
		//_rootFixedSystems.Initialize();
	}
	
	private void Update() {
		_rootSystems.Execute();
		_rootSystems.Cleanup();
	}
	
	private void FixedUpdate() {
		//_rootFixedSystems.Execute();
		//_rootFixedSystems.Cleanup();
	}
	
	private void OnDestroy() {
		_rootSystems.TearDown();
		//_rootFixedSystems.TearDown();
	}
	
	private void AddEntitiesIds() {
		foreach (var context in _contexts.allContexts) {
			if (context.contextInfo.componentTypes.Contains(typeof(IdComponent))) {
				context.OnEntityCreated += AddId;
			}
		}
	}
	
	private void AddId(IContext context, IEntity entity) {
		(entity as IIdEntity).ReplaceId(entity.creationIndex);
	}
}