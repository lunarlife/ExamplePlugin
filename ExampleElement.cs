using UndefinedNetworking.GameEngine.UI;
using UndefinedNetworking.GameEngine.UI.Components;
using UndefinedServer.UI.Elements;

namespace ExamplePlugin;

public class ExampleElement : UIElement
{
    public ExampleElement(UIElement? parent) : base(parent)
    {
    }

    public override ViewParameters CreateNewView(IUIViewer viewer)
    {
        return new();
    }

    public override IEnumerable<UIComponent> Components { get; }
}