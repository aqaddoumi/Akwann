using Entitas;
using Entitas.CodeGeneration.Attributes;

[Core, Service]
public sealed class IdComponent : IComponent {
    [PrimaryEntityIndex]
    public int value;
}