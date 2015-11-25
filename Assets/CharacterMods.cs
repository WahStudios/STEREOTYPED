using UnityEngine;
using System.Collections;

public class CharacterMods : MonoBehaviour {
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

	public int maxArmorMods = 3;
	public int maxCyborgMods=3;
	public int maxDNAMods=3;
	public int maxGunMods=3;
	public int maxMeleeMods=3;
	public int maxGrenadeMods=3;
	public int maxSuperAbilities=3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
