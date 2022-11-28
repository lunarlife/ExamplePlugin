using UndefinedServer;
using UndefinedServer.Plugins;

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
    }
    protected override void OnDisable()
    {
        Undefined.Logger.Info("Goodbye World!");
    }
}