using Networking.Packets;
using UndefinedNetworking.Events.Mouse;
using UndefinedNetworking.GameEngine.UI.Elements.Enums;
using UndefinedServer;
using UndefinedServer.Events.PlayerEvents;
using UndefinedServer.Plugins;
using UndefinedServer.UI.Elements;
using Utils;
using Utils.Events;

namespace ExamplePlugin;

public sealed class ExamplePlugin : Plugin
{
    public override string Name => "Example";

    public override PluginConfiguration Configuration { get; } = new()
    {
        PluginVersion = "1.0"
    };

    protected override void OnEnable()
    {
        Undefined.Logger.Info("Hello World!");
        this.RegisterListener();
    }
    
    protected override void OnDisable()
    {
        Undefined.Logger.Info("Goodbye World!");
    }

    [EventHandler]
    private void OnJoinPlayer(PlayerConnectedEvent e)
    {
        var text = new Text(new Rect(100, 100, 100, 100), "server text", Color.Aqua, fontStyle: FontStyle.Strikethrough);
        var view = e.Player.Open(text);
        Undefined.Logger.Info($"{e.Player.Nickname} open text with id " + view.Identifier);
    }

    [EventHandler]
    private void OnKeyUp(UIMouseUpEvent e)
    {
        Undefined.Logger.Info("up");
    }

    [EventHandler]
    private void OnKeyHolding(UIMouseHoldingEvent e)
    {
        Undefined.Logger.Info("holding");
    }
    
    [EventHandler]
    private void OnKeyDown(UIMouseDownEvent e)
    {
        Undefined.Logger.Info("down");
    }
    [EventHandler]
    private void OnKeyExit(UIMouseExitEvent e)
    {
        Undefined.Logger.Info("exit");
    }
    [EventHandler]
    private void OnKeyEnter(UIMouseEnterEvent e)
    {
        Undefined.Logger.Info("enter");
    }
}