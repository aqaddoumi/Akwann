using Entitas;
using Entitas.CodeGeneration.Attributes;
 
[Service]
[Unique]
public sealed class ViewServiceComponent : IComponent {
    public IViewService value;
}