using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class UnityViewService : IViewService {

    private Contexts _contexts;
    private Transform _root;
    
    public UnityViewService() {
        _contexts = Contexts.sharedInstance;
        
        if (_root == null) {
            _root = new GameObject("World").transform;
        }
    }

    public void LoadAsset(IEntity entity, string asset) {

        var gameEntity = (CoreEntity) entity;

        var viewObject = GameObject.Instantiate(Resources.Load<GameObject>(string.Format("Prefabs/{0}", asset)), _root.transform);
        if (viewObject == null) {
            throw new NullReferenceException(string.Format("{0} not found", asset));
        }

        var view = viewObject.GetComponent<IView>();
        if (view != null) {
            view.InitializeView(_contexts, entity);
        }

        var eventListeners = viewObject.GetComponents<IEventListener>();
        foreach (var listener in eventListeners) {
            listener.RegisterListeners(entity);
        }
    }
}