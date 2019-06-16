using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Core, Service]
[Event(EventTarget.Self)]
public class PositionComponent : IComponent {
    public Vector3 value;
}