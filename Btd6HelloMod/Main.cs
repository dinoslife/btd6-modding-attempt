using BTD_Mod_Helper;
using MelonLoader;

[assembly: MelonInfo(typeof(Btd6HelloMod.Main), Btd6HelloMod.Main.ModName, Btd6HelloMod.Main.Version, Btd6HelloMod.Main.Author)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Btd6HelloMod;

public sealed class Main : BloonsTD6Mod
{
    public const string ModName = "PhightingDeitiesHeroPack";
    public const string Version = "0.3.0";
    public const string Author = "Codex + User";

    public override void OnApplicationStart()
    {
        MelonLogger.Msg("PHIGHTING Hero Pack loaded: 9 heroes with 20 self-levels each.");
    }
}
