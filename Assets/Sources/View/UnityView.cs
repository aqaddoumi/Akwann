using Entitas;
using Entitas.Unity;
using UnityEngine;

public class UnityView : MonoBehaviour, IView, ICoreDestroyedListener {
    
    private CoreEntity _entity;

    public void InitializeView(Contexts contexts, IEntity entity) {
        _entity = (CoreEntity) entity;
        _entity.AddCoreDestroyedListener(this);

        gameObject.Link(entity);
    }

    public void OnDestroyed(CoreEntity entity) {
        gameObject.Unlink();
        Destroy(gameObject);
    }
}