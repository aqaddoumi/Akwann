using Entitas;
using UnityEngine;

public sealed class UpdatePositionByVelocitySystem : IExecuteSystem {
    
    private readonly Contexts _contexts;
    private readonly CoreContext _context;
    private IGroup<CoreEntity> _group;
    
    public UpdatePositionByVelocitySystem(Contexts contexts) {
        _contexts = contexts;
        _context = _contexts.core;
        _group = _context.GetGroup(CoreMatcher.AllOf(CoreMatcher.Position, CoreMatcher.Velocity));
    }
         
    public void Execute () {
        foreach (var e in _group.GetEntities()) {
            Vector3 position = e.position.value;
            Vector3 velocity = e.velocity.value;
            position += velocity * Time.deltaTime;
            e.ReplacePosition(position);
        }
    }
}