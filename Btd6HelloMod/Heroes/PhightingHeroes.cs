using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;

namespace Btd6HelloMod.Heroes;

public static class PhightingHeroNotes
{
    public const string Disclaimer = "Hero scaffold for PHIGHTING cast. Stats/abilities are placeholders for tuning.";
}

public sealed class DarkheartHero : ModHero
{
    public override string TowerSet => "Primary";
    public override string BaseTower => "NinjaMonkey";
    public override int Cost => 700;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Darkheart";

    public override string Description =>
        "Shadow deity hero focused on fast cursed strikes.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class DarkheartLevel1 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 1;
    public override string Description => "Darkheart level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel2 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 2;
    public override string Description => "Darkheart level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel3 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 3;
    public override string Description => "Darkheart level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel4 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 4;
    public override string Description => "Darkheart level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel5 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 5;
    public override string Description => "Darkheart level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel6 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 6;
    public override string Description => "Darkheart level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel7 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 7;
    public override string Description => "Darkheart level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel8 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 8;
    public override string Description => "Darkheart level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel9 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 9;
    public override string Description => "Darkheart level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel10 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 10;
    public override string Description => "Darkheart level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel11 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 11;
    public override string Description => "Darkheart level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel12 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 12;
    public override string Description => "Darkheart level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel13 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 13;
    public override string Description => "Darkheart level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel14 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 14;
    public override string Description => "Darkheart level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel15 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 15;
    public override string Description => "Darkheart level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel16 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 16;
    public override string Description => "Darkheart level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel17 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 17;
    public override string Description => "Darkheart level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel18 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 18;
    public override string Description => "Darkheart level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel19 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 19;
    public override string Description => "Darkheart level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DarkheartLevel20 : ModHeroLevel<DarkheartHero>
{
    public override int Level => 20;
    public override string Description => "Darkheart level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaHero : ModHero
{
    public override string TowerSet => "Magic";
    public override string BaseTower => "WizardMonkey";
    public override int Cost => 750;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Illumina";

    public override string Description =>
        "Radiant deity hero with piercing light projectiles.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class IlluminaLevel1 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 1;
    public override string Description => "Illumina level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel2 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 2;
    public override string Description => "Illumina level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel3 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 3;
    public override string Description => "Illumina level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel4 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 4;
    public override string Description => "Illumina level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel5 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 5;
    public override string Description => "Illumina level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel6 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 6;
    public override string Description => "Illumina level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel7 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 7;
    public override string Description => "Illumina level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel8 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 8;
    public override string Description => "Illumina level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel9 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 9;
    public override string Description => "Illumina level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel10 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 10;
    public override string Description => "Illumina level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel11 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 11;
    public override string Description => "Illumina level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel12 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 12;
    public override string Description => "Illumina level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel13 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 13;
    public override string Description => "Illumina level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel14 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 14;
    public override string Description => "Illumina level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel15 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 15;
    public override string Description => "Illumina level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel16 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 16;
    public override string Description => "Illumina level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel17 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 17;
    public override string Description => "Illumina level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel18 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 18;
    public override string Description => "Illumina level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel19 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 19;
    public override string Description => "Illumina level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IlluminaLevel20 : ModHeroLevel<IlluminaHero>
{
    public override int Level => 20;
    public override string Description => "Illumina level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankHero : ModHero
{
    public override string TowerSet => "Military";
    public override string BaseTower => "SniperMonkey";
    public override int Cost => 780;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Venomshank";

    public override string Description =>
        "Poison deity hero that weakens bloons over time.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class VenomshankLevel1 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 1;
    public override string Description => "Venomshank level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel2 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 2;
    public override string Description => "Venomshank level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel3 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 3;
    public override string Description => "Venomshank level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel4 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 4;
    public override string Description => "Venomshank level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel5 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 5;
    public override string Description => "Venomshank level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel6 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 6;
    public override string Description => "Venomshank level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel7 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 7;
    public override string Description => "Venomshank level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel8 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 8;
    public override string Description => "Venomshank level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel9 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 9;
    public override string Description => "Venomshank level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel10 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 10;
    public override string Description => "Venomshank level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel11 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 11;
    public override string Description => "Venomshank level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel12 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 12;
    public override string Description => "Venomshank level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel13 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 13;
    public override string Description => "Venomshank level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel14 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 14;
    public override string Description => "Venomshank level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel15 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 15;
    public override string Description => "Venomshank level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel16 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 16;
    public override string Description => "Venomshank level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel17 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 17;
    public override string Description => "Venomshank level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel18 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 18;
    public override string Description => "Venomshank level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel19 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 19;
    public override string Description => "Venomshank level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class VenomshankLevel20 : ModHeroLevel<VenomshankHero>
{
    public override int Level => 20;
    public override string Description => "Venomshank level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandHero : ModHero
{
    public override string TowerSet => "Primary";
    public override string BaseTower => "TackShooter";
    public override int Cost => 730;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Firebrand";

    public override string Description =>
        "Flame deity hero with escalating burn pressure.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class FirebrandLevel1 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 1;
    public override string Description => "Firebrand level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel2 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 2;
    public override string Description => "Firebrand level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel3 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 3;
    public override string Description => "Firebrand level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel4 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 4;
    public override string Description => "Firebrand level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel5 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 5;
    public override string Description => "Firebrand level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel6 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 6;
    public override string Description => "Firebrand level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel7 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 7;
    public override string Description => "Firebrand level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel8 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 8;
    public override string Description => "Firebrand level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel9 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 9;
    public override string Description => "Firebrand level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel10 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 10;
    public override string Description => "Firebrand level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel11 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 11;
    public override string Description => "Firebrand level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel12 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 12;
    public override string Description => "Firebrand level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel13 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 13;
    public override string Description => "Firebrand level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel14 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 14;
    public override string Description => "Firebrand level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel15 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 15;
    public override string Description => "Firebrand level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel16 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 16;
    public override string Description => "Firebrand level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel17 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 17;
    public override string Description => "Firebrand level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel18 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 18;
    public override string Description => "Firebrand level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel19 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 19;
    public override string Description => "Firebrand level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class FirebrandLevel20 : ModHeroLevel<FirebrandHero>
{
    public override int Level => 20;
    public override string Description => "Firebrand level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceHero : ModHero
{
    public override string TowerSet => "Magic";
    public override string BaseTower => "Druid";
    public override int Cost => 760;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Windforce";

    public override string Description =>
        "Storm deity hero that manipulates attack speed and knockback.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class WindforceLevel1 : ModHeroLevel<WindforceHero>
{
    public override int Level => 1;
    public override string Description => "Windforce level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel2 : ModHeroLevel<WindforceHero>
{
    public override int Level => 2;
    public override string Description => "Windforce level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel3 : ModHeroLevel<WindforceHero>
{
    public override int Level => 3;
    public override string Description => "Windforce level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel4 : ModHeroLevel<WindforceHero>
{
    public override int Level => 4;
    public override string Description => "Windforce level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel5 : ModHeroLevel<WindforceHero>
{
    public override int Level => 5;
    public override string Description => "Windforce level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel6 : ModHeroLevel<WindforceHero>
{
    public override int Level => 6;
    public override string Description => "Windforce level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel7 : ModHeroLevel<WindforceHero>
{
    public override int Level => 7;
    public override string Description => "Windforce level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel8 : ModHeroLevel<WindforceHero>
{
    public override int Level => 8;
    public override string Description => "Windforce level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel9 : ModHeroLevel<WindforceHero>
{
    public override int Level => 9;
    public override string Description => "Windforce level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel10 : ModHeroLevel<WindforceHero>
{
    public override int Level => 10;
    public override string Description => "Windforce level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel11 : ModHeroLevel<WindforceHero>
{
    public override int Level => 11;
    public override string Description => "Windforce level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel12 : ModHeroLevel<WindforceHero>
{
    public override int Level => 12;
    public override string Description => "Windforce level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel13 : ModHeroLevel<WindforceHero>
{
    public override int Level => 13;
    public override string Description => "Windforce level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel14 : ModHeroLevel<WindforceHero>
{
    public override int Level => 14;
    public override string Description => "Windforce level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel15 : ModHeroLevel<WindforceHero>
{
    public override int Level => 15;
    public override string Description => "Windforce level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel16 : ModHeroLevel<WindforceHero>
{
    public override int Level => 16;
    public override string Description => "Windforce level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel17 : ModHeroLevel<WindforceHero>
{
    public override int Level => 17;
    public override string Description => "Windforce level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel18 : ModHeroLevel<WindforceHero>
{
    public override int Level => 18;
    public override string Description => "Windforce level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel19 : ModHeroLevel<WindforceHero>
{
    public override int Level => 19;
    public override string Description => "Windforce level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class WindforceLevel20 : ModHeroLevel<WindforceHero>
{
    public override int Level => 20;
    public override string Description => "Windforce level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerHero : ModHero
{
    public override string TowerSet => "Magic";
    public override string BaseTower => "IceMonkey";
    public override int Cost => 740;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Icedagger";

    public override string Description =>
        "Frost deity hero specializing in chill and freeze control.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class IcedaggerLevel1 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 1;
    public override string Description => "Icedagger level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel2 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 2;
    public override string Description => "Icedagger level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel3 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 3;
    public override string Description => "Icedagger level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel4 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 4;
    public override string Description => "Icedagger level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel5 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 5;
    public override string Description => "Icedagger level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel6 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 6;
    public override string Description => "Icedagger level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel7 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 7;
    public override string Description => "Icedagger level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel8 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 8;
    public override string Description => "Icedagger level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel9 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 9;
    public override string Description => "Icedagger level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel10 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 10;
    public override string Description => "Icedagger level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel11 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 11;
    public override string Description => "Icedagger level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel12 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 12;
    public override string Description => "Icedagger level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel13 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 13;
    public override string Description => "Icedagger level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel14 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 14;
    public override string Description => "Icedagger level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel15 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 15;
    public override string Description => "Icedagger level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel16 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 16;
    public override string Description => "Icedagger level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel17 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 17;
    public override string Description => "Icedagger level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel18 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 18;
    public override string Description => "Icedagger level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel19 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 19;
    public override string Description => "Icedagger level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class IcedaggerLevel20 : ModHeroLevel<IcedaggerHero>
{
    public override int Level => 20;
    public override string Description => "Icedagger level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerHero : ModHero
{
    public override string TowerSet => "Military";
    public override string BaseTower => "BoomerangMonkey";
    public override int Cost => 800;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Ghostwalker";

    public override string Description =>
        "Spectral deity hero with phasing multi-hit attacks.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class GhostwalkerLevel1 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 1;
    public override string Description => "Ghostwalker level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel2 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 2;
    public override string Description => "Ghostwalker level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel3 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 3;
    public override string Description => "Ghostwalker level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel4 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 4;
    public override string Description => "Ghostwalker level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel5 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 5;
    public override string Description => "Ghostwalker level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel6 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 6;
    public override string Description => "Ghostwalker level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel7 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 7;
    public override string Description => "Ghostwalker level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel8 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 8;
    public override string Description => "Ghostwalker level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel9 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 9;
    public override string Description => "Ghostwalker level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel10 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 10;
    public override string Description => "Ghostwalker level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel11 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 11;
    public override string Description => "Ghostwalker level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel12 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 12;
    public override string Description => "Ghostwalker level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel13 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 13;
    public override string Description => "Ghostwalker level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel14 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 14;
    public override string Description => "Ghostwalker level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel15 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 15;
    public override string Description => "Ghostwalker level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel16 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 16;
    public override string Description => "Ghostwalker level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel17 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 17;
    public override string Description => "Ghostwalker level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel18 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 18;
    public override string Description => "Ghostwalker level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel19 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 19;
    public override string Description => "Ghostwalker level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class GhostwalkerLevel20 : ModHeroLevel<GhostwalkerHero>
{
    public override int Level => 20;
    public override string Description => "Ghostwalker level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkHero : ModHero
{
    public override string TowerSet => "Primary";
    public override string BaseTower => "DartMonkey";
    public override int Cost => 770;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Valk";

    public override string Description =>
        "Golden deity hero with high tempo precision damage.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class ValkLevel1 : ModHeroLevel<ValkHero>
{
    public override int Level => 1;
    public override string Description => "Valk level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel2 : ModHeroLevel<ValkHero>
{
    public override int Level => 2;
    public override string Description => "Valk level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel3 : ModHeroLevel<ValkHero>
{
    public override int Level => 3;
    public override string Description => "Valk level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel4 : ModHeroLevel<ValkHero>
{
    public override int Level => 4;
    public override string Description => "Valk level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel5 : ModHeroLevel<ValkHero>
{
    public override int Level => 5;
    public override string Description => "Valk level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel6 : ModHeroLevel<ValkHero>
{
    public override int Level => 6;
    public override string Description => "Valk level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel7 : ModHeroLevel<ValkHero>
{
    public override int Level => 7;
    public override string Description => "Valk level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel8 : ModHeroLevel<ValkHero>
{
    public override int Level => 8;
    public override string Description => "Valk level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel9 : ModHeroLevel<ValkHero>
{
    public override int Level => 9;
    public override string Description => "Valk level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel10 : ModHeroLevel<ValkHero>
{
    public override int Level => 10;
    public override string Description => "Valk level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel11 : ModHeroLevel<ValkHero>
{
    public override int Level => 11;
    public override string Description => "Valk level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel12 : ModHeroLevel<ValkHero>
{
    public override int Level => 12;
    public override string Description => "Valk level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel13 : ModHeroLevel<ValkHero>
{
    public override int Level => 13;
    public override string Description => "Valk level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel14 : ModHeroLevel<ValkHero>
{
    public override int Level => 14;
    public override string Description => "Valk level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel15 : ModHeroLevel<ValkHero>
{
    public override int Level => 15;
    public override string Description => "Valk level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel16 : ModHeroLevel<ValkHero>
{
    public override int Level => 16;
    public override string Description => "Valk level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel17 : ModHeroLevel<ValkHero>
{
    public override int Level => 17;
    public override string Description => "Valk level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel18 : ModHeroLevel<ValkHero>
{
    public override int Level => 18;
    public override string Description => "Valk level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel19 : ModHeroLevel<ValkHero>
{
    public override int Level => 19;
    public override string Description => "Valk level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class ValkLevel20 : ModHeroLevel<ValkHero>
{
    public override int Level => 20;
    public override string Description => "Valk level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomHero : ModHero
{
    public override string TowerSet => "Magic";
    public override string BaseTower => "SuperMonkey";
    public override int Cost => 820;
    public override int MaxLevel => 20;

    public override string DisplayName =>
        "Dom";

    public override string Description =>
        "Void deity hero with heavy burst and debuff utility.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        // Placeholder baseline hero stat tuning.
    }
}

public sealed class DomLevel1 : ModHeroLevel<DomHero>
{
    public override int Level => 1;
    public override string Description => "Dom level 1 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel2 : ModHeroLevel<DomHero>
{
    public override int Level => 2;
    public override string Description => "Dom level 2 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel3 : ModHeroLevel<DomHero>
{
    public override int Level => 3;
    public override string Description => "Dom level 3 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel4 : ModHeroLevel<DomHero>
{
    public override int Level => 4;
    public override string Description => "Dom level 4 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel5 : ModHeroLevel<DomHero>
{
    public override int Level => 5;
    public override string Description => "Dom level 5 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel6 : ModHeroLevel<DomHero>
{
    public override int Level => 6;
    public override string Description => "Dom level 6 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel7 : ModHeroLevel<DomHero>
{
    public override int Level => 7;
    public override string Description => "Dom level 7 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel8 : ModHeroLevel<DomHero>
{
    public override int Level => 8;
    public override string Description => "Dom level 8 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel9 : ModHeroLevel<DomHero>
{
    public override int Level => 9;
    public override string Description => "Dom level 9 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel10 : ModHeroLevel<DomHero>
{
    public override int Level => 10;
    public override string Description => "Dom level 10 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel11 : ModHeroLevel<DomHero>
{
    public override int Level => 11;
    public override string Description => "Dom level 11 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel12 : ModHeroLevel<DomHero>
{
    public override int Level => 12;
    public override string Description => "Dom level 12 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel13 : ModHeroLevel<DomHero>
{
    public override int Level => 13;
    public override string Description => "Dom level 13 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel14 : ModHeroLevel<DomHero>
{
    public override int Level => 14;
    public override string Description => "Dom level 14 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel15 : ModHeroLevel<DomHero>
{
    public override int Level => 15;
    public override string Description => "Dom level 15 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel16 : ModHeroLevel<DomHero>
{
    public override int Level => 16;
    public override string Description => "Dom level 16 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel17 : ModHeroLevel<DomHero>
{
    public override int Level => 17;
    public override string Description => "Dom level 17 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel18 : ModHeroLevel<DomHero>
{
    public override int Level => 18;
    public override string Description => "Dom level 18 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel19 : ModHeroLevel<DomHero>
{
    public override int Level => 19;
    public override string Description => "Dom level 19 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}

public sealed class DomLevel20 : ModHeroLevel<DomHero>
{
    public override int Level => 20;
    public override string Description => "Dom level 20 placeholder power spike.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        // TODO: add concrete level-up effect (damage, pierce, cooldown, ability unlocks).
    }
}
