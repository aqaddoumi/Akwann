using Entitas;
using UnityEngine;

public class PositionListener : MonoBehaviour, IEventListener, ICorePositionListener
{
    private CoreEntity _entity;
    
    public void RegisterListeners(IEntity entity)
    {
        _entity = (CoreEntity) entity;
        _entity.AddCorePositionListener(this);

        if (!_entity.hasPosition) {
            Debug.Log("Entity " + _entity.id.value + " doesn't have position component");
        }
        else {
            OnPosition(_entity, _entity.position.value); 
        }        
    }

    public void OnPosition(CoreEntity e, Vector3 value) {
        transform.localPosition = value;
    }
}