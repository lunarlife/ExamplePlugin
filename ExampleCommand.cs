using UndefinedNetworking.Chats;
using UndefinedNetworking.Commands;
using UndefinedNetworking.Gameplay.Chat;
using UndefinedServer;
using UndefinedServer.Commands;
using UndefinedServer.Commands.ParameterTypes;

namespace ExamplePlugin;

public class ExampleCommand : Command
{
    public override string Prefix => "console";
    public override string Description => "shows a message in console";

    public override ParameterType[]? Parameters { get; } =
    {
        new PlayerNicknameParameterType(true, false),
        new StringParameterType(true, true)
    };
    
    public override void Execute(ISender sender, CommandParameter[]? args, ChatType type)
    {
        if (sender is not Player current) return;
        var player = args![0].Cast<Player>();
        //player.SendMessage(new ChatMessage());
    }

}