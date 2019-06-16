using Entitas;
using Entitas.CodeGeneration.Attributes;

[Core, Service]
[Event(EventTarget.Self)]
public sealed class DestroyedComponent : IComponent {
}