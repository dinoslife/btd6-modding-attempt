# PHIGHTING Hero Pack (BTD6 Mod Scaffold)

Updated per your request: this is now a **hero-only scaffold**.

## Included heroes (9 total)

1. Darkheart
2. Illumina
3. Venomshank
4. Firebrand
5. Windforce
6. Icedagger
7. Ghostwalker
8. Valk (yellow)
9. Dom (purple)

## Structure

- These are implemented as hero classes (not standard 3-path towers).
- Each hero is configured for **20 levels** and is intended to self-upgrade through hero XP progression.
- Each hero has 20 level classes scaffolded for you to fill with real mechanics.

## What is currently scaffolded

- `9` `ModHero` classes.
- `180` `ModHeroLevel` classes (`9 heroes × 20 levels`).
- Placeholder descriptions and `ApplyUpgrade` methods for level effects.

## Files

- `Btd6HelloMod/Main.cs` — mod entry + startup log.
- `Btd6HelloMod/Heroes/PhightingHeroes.cs` — all hero and level scaffolds.
- `Btd6HelloMod/Btd6HelloMod.csproj` — project references for local setup.

## Build setup

1. Install MelonLoader into BTD6.
2. Ensure `BTD_Mod_Helper.dll` is available.
3. Update `HintPath` values in `Btd6HelloMod.csproj`.
4. Build and place output DLL in your BTD6 `Mods/` folder.

```bash
dotnet build Btd6HelloMod/Btd6HelloMod.csproj -c Release
```

## Next pass I can do for you

I can now implement **unique level milestones** for each hero (Lv3/Lv7/Lv10/Lv20 power spikes, abilities, debuffs, anti-MOAB roles, and synergy rules) so they actually play differently instead of being placeholders.
