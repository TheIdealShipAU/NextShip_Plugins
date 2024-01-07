using System.Reflection;
using NextShip.Api;
using NextShip.Api.Bases;
using NextShip.Api.Interfaces;

namespace VoiceChatPlugin;

public class VoiceChatPlugin : ShipPlugin
{
    public Assembly RootAssembly { get; private set; }

    public string RootPath = NextPaths.RootDirectory;
    
    public override void Load()
    {
        RootAssembly = Assembly.GetExecutingAssembly();
    }

    public override List<INextAdd> NextAdd()
    {
        return INextAdd.GetAdds(RootAssembly);
    }
}