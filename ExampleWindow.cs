using UndefinedNetworking.GameEngine;
using UndefinedNetworking.GameEngine.Input;
using UndefinedNetworking.GameEngine.UI;
using UndefinedNetworking.GameEngine.UI.Components;
using UndefinedNetworking.GameEngine.UI.Components.Mouse;
using UndefinedServer.UI.Windows;

namespace ExamplePlugin;

public class ExampleWindow : Window
{
    private readonly List<UIComponent> _components = new()
    {
        new MouseDownHandlerComponent
        {
            Keys = MouseKey.Left
        }
    };

    public override ViewParameters CreateNewView(IUIViewer viewer) =>
        new()
        {
            
        };

    public override IEnumerable<UIComponent> Components => _components;
}