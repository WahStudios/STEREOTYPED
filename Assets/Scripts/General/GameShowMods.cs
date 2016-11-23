using UnityEngine;
using System.Collections;

public class GameShowMods : MonoBehaviour {
	public enum ArmorMod {mod1,mod2,mod3}
	public ArmorMod armorMod;
	public enum CyborgMod {mod1,mod2,mod3}
	public CyborgMod cyborgMod;
	public enum DNAMod {mod1,mod2,mod3}
	public DNAMod DNAmod;
	public enum GunMod {mod1,mod2,mod3}
	public GunMod gunMod;
	public enum MeleeMod {mod1,mod2,mod3}
	public MeleeMod meleeMod;
	public enum GrenadeMod {mod1,mod2,mod3}
	public GrenadeMod grenadeMod;
	public enum Super{ability1,ability2,ability3}
	public Super super;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("GameShowArmorMod") == 1)
            armorMod = ArmorMod.mod1;
        else if (PlayerPrefs.GetInt("GameShowArmorMod") == 2)
            armorMod = ArmorMod.mod2;
        else if (PlayerPrefs.GetInt("GameShowArmorMod") == 3)
            armorMod = ArmorMod.mod3;
        
        if(PlayerPrefs.GetInt("GameShowCyborgMod") == 1)
            cyborgMod = CyborgMod.mod1;
        else if (PlayerPrefs.GetInt("GameShowCyborgMod") == 2)
            cyborgMod = CyborgMod.mod2;
        else if (PlayerPrefs.GetInt("GameShowCyborgMod") == 3)
            cyborgMod = CyborgMod.mod3;

        if (PlayerPrefs.GetInt("GameShowDNAMod") == 1)
            DNAmod = DNAMod.mod1;
        else if (PlayerPrefs.GetInt("GameShowDNAMod") == 2)
            DNAmod = DNAMod.mod2;
        else if (PlayerPrefs.GetInt("GameShowDNAMod") == 3)
            DNAmod = DNAMod.mod3;

        if (PlayerPrefs.GetInt("GameShowGrenadeMod") == 1)
            grenadeMod = GrenadeMod.mod1;
        else if (PlayerPrefs.GetInt("GameShowGrenadeMod") == 2)
            grenadeMod = GrenadeMod.mod2;
        else if (PlayerPrefs.GetInt("GameShowGrenadeMod") == 3)
            grenadeMod = GrenadeMod.mod3;

        if (PlayerPrefs.GetInt("GameShowGunMod") == 1)
            gunMod = GunMod.mod1;
        else if (PlayerPrefs.GetInt("GameShowGunMod") == 2)
            gunMod = GunMod.mod2;
        else if (PlayerPrefs.GetInt("GameShowGunMod") == 3)
            gunMod = GunMod.mod3;

        if (PlayerPrefs.GetInt("GameShowMeleeMod") == 1)
            meleeMod = MeleeMod.mod1;
        else if (PlayerPrefs.GetInt("GameShowMeleeMod") == 2)
            meleeMod = MeleeMod.mod2;
        else if (PlayerPrefs.GetInt("GameShowMeleeMod") == 3)
            meleeMod = MeleeMod.mod3;

        if (PlayerPrefs.GetInt("GameShowSuper") == 1)
            super = Super.ability1;
        else if (PlayerPrefs.GetInt("GameShowSuper") ==2)
            super = Super.ability2;
        else if (PlayerPrefs.GetInt("GameShowSuper") == 3)
            super = Super.ability3;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
