using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Core.Capabilities;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Entities.Constants;
using CounterStrikeSharp.API.Modules.Utils;
namespace MapStartPlugin;

// [MinimumApiVersion(160)]
public class MapStartPlugin : BasePlugin
{
    public override string ModuleName => "MapStartCommand";
    public override string ModuleDescription => "https://github.com/bili12685/mapstartcommand";
    public override string ModuleAuthor => "ottogame&cxk";
    public override string ModuleVersion => "1.0.0";

    public override void Load(bool hotReload)
    {
        Console.WriteLine($"{ModuleName} loaded successfully!");
        RegisterEventHandler<EventWarmupEnd>((@event, info) =>
        {
            Server.ExecuteCommand("mp_restartgame 1");

            return HookResult.Continue;
        });
    }
}
