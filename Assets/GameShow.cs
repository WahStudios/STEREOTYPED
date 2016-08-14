using UnityEngine;
using System.Collections;


public class GameShow : MonoBehaviour {
    public string gameShowScene = "RandomRoomGenerator";
    public CharacterStats char1Stats;
    public CharacterMods char1Mods;
    public CharacterAttributes char1Attr;

    public CharacterStats char2Stats;
    public CharacterMods char2Mods;
    public CharacterAttributes char2Attr;


   public void Select1()
    {
        PlayerPrefs.SetInt("GameShowCharacterHP", char1Stats.HP);
        PlayerPrefs.SetInt("GameShowCharacterMeleeDamage", char1Stats.meleeDamage);
        PlayerPrefs.SetInt("GameShowCharacterGunDamage", char1Stats.gunDamage);
        PlayerPrefs.SetInt("GameShowCharacterBulletRange", char1Stats.bulletRange);
        PlayerPrefs.SetInt("GameShowCharacterFiringSpeed", char1Stats.firingSpeed);
        PlayerPrefs.SetInt("GameShowCharacterBulletSpeed", char1Stats.bulletSpeed);
        PlayerPrefs.SetInt("GameShowCharacterAccuracy", char1Stats.accuracy);
        PlayerPrefs.SetInt("GameShowCharacterTotalAmmo", char1Stats.totalAmmo);
        PlayerPrefs.SetInt("GameShowCharacterMovementSpeed", char1Stats.movementSpeed);
        PlayerPrefs.SetInt("GameShowCharacterJumpHeight", char1Stats.jumpHeight);
        // -- need to set up stats below first
        //PlayerPrefs.SetInt("GameShowCharacterAmmoClip", char1Stats.ammoClip);
        // PlayerPrefs.SetInt("GameShowCharacterArmor", char1Stats.armor);
        if (char1Mods.meleeMod == CharacterMods.MeleeMod.mod1)
            PlayerPrefs.SetInt("GameShowMeleeMod", 1);
        else if (char1Mods.meleeMod == CharacterMods.MeleeMod.mod2)
            PlayerPrefs.SetInt("GameShowMeleeMod", 2);
        else if (char1Mods.meleeMod == CharacterMods.MeleeMod.mod3)
            PlayerPrefs.SetInt("GameShowMeleeMod", 3);

        if (char1Mods.armorMod == CharacterMods.ArmorMod.mod1)
            PlayerPrefs.SetInt("GameShowArmorMod", 1);
        else if (char1Mods.armorMod == CharacterMods.ArmorMod.mod2)
            PlayerPrefs.SetInt("GameShowArmorMod", 2);
        else if (char1Mods.armorMod == CharacterMods.ArmorMod.mod3)
            PlayerPrefs.SetInt("GameShowArmorMod", 3);

        if (char1Mods.cyborgMod == CharacterMods.CyborgMod.mod1)
            PlayerPrefs.SetInt("GameShowCyborgMod", 1);
        else if(char1Mods.cyborgMod == CharacterMods.CyborgMod.mod2)
            PlayerPrefs.SetInt("GameShowCyborgMod", 2);
        else if (char1Mods.cyborgMod == CharacterMods.CyborgMod.mod3)
            PlayerPrefs.SetInt("GameShowCyborgMod", 3);

        if (char1Mods.DNAmod == CharacterMods.DNAMod.mod1)
            PlayerPrefs.SetInt("GameShowDNAMod", 1);
        else if (char1Mods.DNAmod == CharacterMods.DNAMod.mod2)
            PlayerPrefs.SetInt("GameShowDNAMod", 2);
        else if (char1Mods.DNAmod == CharacterMods.DNAMod.mod3)
            PlayerPrefs.SetInt("GameShowDNAMod", 3);

        if (char1Mods.grenadeMod == CharacterMods.GrenadeMod.mod1)
            PlayerPrefs.SetInt("GameShowGrenadeMod", 1);
       else if (char1Mods.grenadeMod == CharacterMods.GrenadeMod.mod2)
            PlayerPrefs.SetInt("GameShowGrenadeMod",2 );
        else if (char1Mods.grenadeMod == CharacterMods.GrenadeMod.mod3)
            PlayerPrefs.SetInt("GameShowGrenadeMod", 3);

        if (char1Mods.gunMod == CharacterMods.GunMod.mod1)
            PlayerPrefs.SetInt("GameShowGunmod", 1);
        else if (char1Mods.gunMod == CharacterMods.GunMod.mod2)
            PlayerPrefs.SetInt("GameShowGunmod", 2);
        else if (char1Mods.gunMod == CharacterMods.GunMod.mod3)
            PlayerPrefs.SetInt("GameShowGunmod", 3);

        if (char1Mods.super == CharacterMods.Super.ability1)
            PlayerPrefs.SetInt("GameShowSuper", 1);
        else if (char1Mods.super == CharacterMods.Super.ability2)
            PlayerPrefs.SetInt("GameShowSuper", 2);
        else if (char1Mods.super == CharacterMods.Super.ability3)
            PlayerPrefs.SetInt("GameShowSuper", 3);

        //------------------------------

        if (char1Attr.gender == CharacterAttributes.Gender.Male)
            PlayerPrefs.SetInt("GameShowGender", 1);
        else if (char1Attr.gender == CharacterAttributes.Gender.Female)
            PlayerPrefs.SetInt("GameShowGender", 2);

        if (char1Attr.raceSkills == CharacterAttributes.RaceSkills.Skill1)
            PlayerPrefs.SetInt("GameShowRaceSkills", 1);
        else if (char1Attr.raceSkills == CharacterAttributes.RaceSkills.Skill2)
            PlayerPrefs.SetInt("GameShowRaceSkills", 2);
        else if (char1Attr.raceSkills == CharacterAttributes.RaceSkills.Skill3)
            PlayerPrefs.SetInt("GameShowRaceSkills", 3);

        if (char1Attr.skinColor == CharacterAttributes.SkinColor.Black)
            PlayerPrefs.SetInt("GameShowSkinColor", 1);
        else if (char1Attr.skinColor == CharacterAttributes.SkinColor.White)
            PlayerPrefs.SetInt("GameShowSkinColor", 2);
        else if (char1Attr.skinColor == CharacterAttributes.SkinColor.Asian)
            PlayerPrefs.SetInt("GameShowSkinColor", 3);
        else if (char1Attr.skinColor == CharacterAttributes.SkinColor.Jew)
            PlayerPrefs.SetInt("GameShowSkinColor", 4);
        else if (char1Attr.skinColor == CharacterAttributes.SkinColor.Latin)
            PlayerPrefs.SetInt("GameShowSkinColor", 5);
        else if (char1Attr.skinColor == CharacterAttributes.SkinColor.Mutt)
            PlayerPrefs.SetInt("GameShowSkinColor", 6);
        else if (char1Attr.skinColor == CharacterAttributes.SkinColor.Albino)
            PlayerPrefs.SetInt("GameShowSkinColor", 7);



        Application.LoadLevel(gameShowScene);
    }

    public void Select2()
    {
        PlayerPrefs.SetInt("GameShowCharacterHP", char2Stats.HP);
        PlayerPrefs.SetInt("GameShowCharacterMeleeDamage", char2Stats.meleeDamage);
        PlayerPrefs.SetInt("GameShowCharacterGunDamage", char2Stats.gunDamage);
        PlayerPrefs.SetInt("GameShowCharacterBulletRange", char2Stats.bulletRange);
        PlayerPrefs.SetInt("GameShowCharacterFiringSpeed", char2Stats.firingSpeed);
        PlayerPrefs.SetInt("GameShowCharacterBulletSpeed", char2Stats.bulletSpeed);
        PlayerPrefs.SetInt("GameShowCharacterAccuracy", char2Stats.accuracy);
        PlayerPrefs.SetInt("GameShowCharacterTotalAmmo", char2Stats.totalAmmo);
        PlayerPrefs.SetInt("GameShowCharacterMovementSpeed", char2Stats.movementSpeed);
        PlayerPrefs.SetInt("GameShowCharacterJumpHeight", char2Stats.jumpHeight);
        // -- need to set up stats below first
        //PlayerPrefs.SetInt("GameShowCharacterAmmoClip", char2Stats.ammoClip);
        // PlayerPrefs.SetInt("GameShowCharacterArmor", char2Stats.armor);

        if (char2Mods.meleeMod == CharacterMods.MeleeMod.mod1)
            PlayerPrefs.SetInt("GameShowMeleeMod", 1);
        else if (char2Mods.meleeMod == CharacterMods.MeleeMod.mod2)
            PlayerPrefs.SetInt("GameShowMeleeMod", 2);
        else if (char2Mods.meleeMod == CharacterMods.MeleeMod.mod3)
            PlayerPrefs.SetInt("GameShowMeleeMod", 3);

        if (char2Mods.armorMod == CharacterMods.ArmorMod.mod1)
            PlayerPrefs.SetInt("GameShowArmorMod", 1);
        else if (char2Mods.armorMod == CharacterMods.ArmorMod.mod2)
            PlayerPrefs.SetInt("GameShowArmorMod", 2);
        else if (char2Mods.armorMod == CharacterMods.ArmorMod.mod3)
            PlayerPrefs.SetInt("GameShowArmorMod", 3);

        if (char2Mods.cyborgMod == CharacterMods.CyborgMod.mod1)
            PlayerPrefs.SetInt("GameShowCyborgMod", 1);
        else if (char2Mods.cyborgMod == CharacterMods.CyborgMod.mod2)
            PlayerPrefs.SetInt("GameShowCyborgMod", 2);
        else if (char2Mods.cyborgMod == CharacterMods.CyborgMod.mod3)
            PlayerPrefs.SetInt("GameShowCyborgMod", 3);

        if (char2Mods.DNAmod == CharacterMods.DNAMod.mod1)
            PlayerPrefs.SetInt("GameShowDNAMod", 1);
        else if (char2Mods.DNAmod == CharacterMods.DNAMod.mod2)
            PlayerPrefs.SetInt("GameShowDNAMod", 2);
        else if (char2Mods.DNAmod == CharacterMods.DNAMod.mod3)
            PlayerPrefs.SetInt("GameShowDNAMod", 3);

        if (char2Mods.grenadeMod == CharacterMods.GrenadeMod.mod1)
            PlayerPrefs.SetInt("GameShowGrenadeMod", 1);
        else if (char2Mods.grenadeMod == CharacterMods.GrenadeMod.mod2)
            PlayerPrefs.SetInt("GameShowGrenadeMod", 2);
        else if (char2Mods.grenadeMod == CharacterMods.GrenadeMod.mod3)
            PlayerPrefs.SetInt("GameShowGrenadeMod", 3);

        if (char2Mods.gunMod == CharacterMods.GunMod.mod1)
            PlayerPrefs.SetInt("GameShowGunMod", 1);
        else if (char2Mods.gunMod == CharacterMods.GunMod.mod2)
            PlayerPrefs.SetInt("GameShowGunMod", 2);
        else if (char2Mods.gunMod == CharacterMods.GunMod.mod3)
            PlayerPrefs.SetInt("GameShowGunMod", 3);

        if (char2Mods.super == CharacterMods.Super.ability1)
            PlayerPrefs.SetInt("GameShowSuper", 1);
        else if (char2Mods.super == CharacterMods.Super.ability2)
            PlayerPrefs.SetInt("GameShowSuper", 2);
        else if (char2Mods.super == CharacterMods.Super.ability3)
            PlayerPrefs.SetInt("GameShowSuper", 3);

        //------------------------------

        if (char2Attr.gender == CharacterAttributes.Gender.Male)
            PlayerPrefs.SetInt("GameShowGender", 1);
        else if (char2Attr.gender == CharacterAttributes.Gender.Female)
            PlayerPrefs.SetInt("GameShowGender", 2);

        if (char2Attr.raceSkills == CharacterAttributes.RaceSkills.Skill1)
            PlayerPrefs.SetInt("GameShowRaceSkills", 1);
        else if (char2Attr.raceSkills == CharacterAttributes.RaceSkills.Skill2)
            PlayerPrefs.SetInt("GameShowRaceSkills", 2);
        else if (char2Attr.raceSkills == CharacterAttributes.RaceSkills.Skill3)
            PlayerPrefs.SetInt("GameShowRaceSkills", 3);

        if (char2Attr.skinColor == CharacterAttributes.SkinColor.Black)
            PlayerPrefs.SetInt("GameShowSkinColor", 1);
        else if (char2Attr.skinColor == CharacterAttributes.SkinColor.White)
            PlayerPrefs.SetInt("GameShowSkinColor", 2);
        else if (char2Attr.skinColor == CharacterAttributes.SkinColor.Asian)
            PlayerPrefs.SetInt("GameShowSkinColor", 3);
        else if (char2Attr.skinColor == CharacterAttributes.SkinColor.Jew)
            PlayerPrefs.SetInt("GameShowSkinColor", 4);
        else if (char2Attr.skinColor == CharacterAttributes.SkinColor.Latin)
            PlayerPrefs.SetInt("GameShowSkinColor", 5);
        else if (char2Attr.skinColor == CharacterAttributes.SkinColor.Mutt)
            PlayerPrefs.SetInt("GameShowSkinColor", 6);
        else if (char2Attr.skinColor == CharacterAttributes.SkinColor.Albino)
            PlayerPrefs.SetInt("GameShowSkinColor", 7);

        Application.LoadLevel(gameShowScene);
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
