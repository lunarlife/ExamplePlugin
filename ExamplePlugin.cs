using Networking.Packets;
using UndefinedNetworking.Core;
using UndefinedNetworking.Events.Mouse;
using UndefinedNetworking.GameEngine;
using UndefinedNetworking.GameEngine.Input;
using UndefinedNetworking.GameEngine.Objects.Components;
using UndefinedNetworking.GameEngine.Scenes;
using UndefinedNetworking.GameEngine.UI;
using UndefinedNetworking.GameEngine.UI.Components;
using UndefinedNetworking.GameEngine.UI.Components.Mouse;
using UndefinedNetworking.GameEngine.UI.Elements.Enums;
using UndefinedNetworking.GameEngine.UI.Elements.Structs;
using UndefinedServer;
using UndefinedServer.Events.PlayerEvents;
using UndefinedServer.GameEngine.Objects;
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
        //var text = new Text(new Rect(100, 100, 100, 100), "server text", Color.Aqua, fontStyle: FontStyle.Strikethrough);
        //var view = e.Player.Open(text);
        e.Player.LoadScene(SceneType.XY);
        var view = e.Player.ActiveScene.OpenView(new ViewParameters
        {
            OriginalRect = new Rect(0, 200, 100, 100),
            Bind = new UIBind
            { 
                Side = Side.TopRight
            }
        });
        var text = e.Player.ActiveScene.OpenView(new ViewParameters
        {
            OriginalRect = new Rect(0, 0, 100, 30),
            Bind = new UIBind
            { 
                Side = Side.TopRight
            },
            Parent = view.Transform
        }).AddComponent<TextComponent>();
        text.Size = new FontSize(32);
        text.Color = Color.Aqua;
        text.Text = "server text";
        Task.Run(async () =>
        {
            await Task.Delay(2000);
            var scroll = view.AddComponent<ScrollComponent>();
            scroll.VerticalScrollSpeed = 1;
            scroll.ViewRect = new Rect(20, 10, 50, 50);
        });
        // Undefined.Logger.Info($"{e.Player.Nickname} open text with id " + text.Identifier);

 

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