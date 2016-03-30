using UnityEngine;
using System.Collections;

public class RandomCharacterGenerator : MonoBehaviour {
	public CharacterStats characterStats;
	public CharacterAttributes characterAttributes;
	public CharacterMods characterMods;
	public CharacterInformationUI charInfoUI;
	public int maxStatDistribution = 10;
	public int statDistribution = 0;
	int defaultAccuracy;
	int defaultBulletRange;
	int defaultBulletSpeed;
	int defaultFiringSpeed;
	int defaultGunDamage;
	int defaultHP;
	int defaultJumpHeight;
	int defualtMeleeDamage;
	int defaultMovemementSpeed;
	int defaultTotalAmmo;
	// Use this for initialization
	void Start () {
		defaultAccuracy = characterStats.accuracy;
		defaultBulletRange = characterStats.bulletRange;
		defaultBulletSpeed = characterStats.bulletSpeed;
		defaultFiringSpeed = characterStats.firingSpeed;
		defaultGunDamage = characterStats.gunDamage;
		defaultHP = characterStats.HP;
		defaultJumpHeight = characterStats.jumpHeight;
		defualtMeleeDamage = characterStats.meleeDamage;
		defaultMovemementSpeed = characterStats.movementSpeed;
		defaultTotalAmmo = characterStats.totalAmmo;
	}
	void RollStats(){
		statDistribution = 0;
		ResetStats ();

	}
	void ResetStats(){
		characterStats.accuracy = defaultAccuracy;
		characterStats.bulletRange = defaultBulletRange;
		characterStats.bulletSpeed = defaultBulletSpeed;
		characterStats.firingSpeed = defaultFiringSpeed;
		characterStats.gunDamage = defaultGunDamage;
		characterStats.HP = defaultHP;
		characterStats.jumpHeight = defaultJumpHeight;
		characterStats.meleeDamage = defualtMeleeDamage;
		characterStats.movementSpeed = defaultMovemementSpeed;
		characterStats.totalAmmo = defaultTotalAmmo;
		RandomRoll ();
		RollAttributes ();
		RollMods ();
	}
	void RandomRoll(){
	if (statDistribution < maxStatDistribution) {
			int statSelection = Random.Range (0, 10);
			if (statSelection == 0) {
				characterStats.accuracy += 1;
			} else if (statSelection == 1) {
				characterStats.bulletRange += 1;
			} else if (statSelection == 2) {
				characterStats.bulletSpeed += 1;
			} else if (statSelection == 3) {
				characterStats.firingSpeed += 1;
			} else if (statSelection == 4) {
				characterStats.gunDamage += 1;
			} else if (statSelection == 5) {
				characterStats.HP += 25;
			} else if (statSelection == 6) {
				characterStats.jumpHeight += 1;
			} else if (statSelection == 7) {
				characterStats.meleeDamage += 1;
			} else if (statSelection == 8) {
				characterStats.movementSpeed += 1;
			} else if (statSelection == 9) {
				characterStats.totalAmmo += 5;
			}
			statDistribution++;
			RandomRoll ();
		} else {
			charInfoUI.DisplayStats();
		}
	}
	void RollAttributes(){
		int randomGender = Random.Range (0, 2);
		if (randomGender == 0) {
			characterAttributes.gender = CharacterAttributes.Gender.Male;
		} else {
			characterAttributes.gender = CharacterAttributes.Gender.Female;
		}
		int randomSkinColor = Random.Range (0, characterAttributes.maxSkinColors);
		if (randomSkinColor == 0) {
			characterAttributes.skinColor = CharacterAttributes.SkinColor.Black;
		} else if (randomSkinColor == 1) {
			characterAttributes.skinColor = CharacterAttributes.SkinColor.White;
		} else if (randomSkinColor == 2) {
			characterAttributes.skinColor = CharacterAttributes.SkinColor.Hispanic;
		}
		int randomRaceSkill = Random.Range (0, characterAttributes.maxRaceSkills);
		if (randomRaceSkill == 0) {
			characterAttributes.raceSkills = CharacterAttributes.RaceSkills.Skill1;
		}
		else if (randomRaceSkill == 1) {
			characterAttributes.raceSkills = CharacterAttributes.RaceSkills.Skill2;
		}
		else if (randomRaceSkill == 2) {
			characterAttributes.raceSkills = CharacterAttributes.RaceSkills.Skill3;
		}
	}
	void RollMods(){
		int randomArmorMod = Random.Range (0, characterMods.maxArmorMods);
		int randomCyborgMod = Random.Range (0, characterMods.maxCyborgMods);
		int randomDNAMod = Random.Range (0, characterMods.maxDNAMods);
		int randomGunMod = Random.Range (0, characterMods.maxGunMods);
		int randomMeleeMod = Random.Range (0, characterMods.maxMeleeMods);
		int randomGrenadeMod = Random.Range (0, characterMods.maxGrenadeMods);
		int randomSuperAbility = Random.Range (0, characterMods.maxSuperAbilities);
		if (randomArmorMod == 0) {
			characterMods.armorMod = CharacterMods.ArmorMod.mod1;
		}
		else if (randomArmorMod == 1) {
			characterMods.armorMod = CharacterMods.ArmorMod.mod2;
		}
		else if (randomArmorMod == 2) {
			characterMods.armorMod = CharacterMods.ArmorMod.mod3;
		}
		if (randomCyborgMod == 0) {
            if (randomArmorMod != 0)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod1;
            else if (randomArmorMod == 0 && randomArmorMod != 1)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod2;
            else if (randomArmorMod == 1 && randomArmorMod != 2)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod3;

		}
		else if (randomCyborgMod== 1) {
            if (randomArmorMod != 1)
            characterMods.cyborgMod = CharacterMods.CyborgMod.mod2;
            else if (randomArmorMod == 1 && randomArmorMod != 2)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod3;
            else if (randomArmorMod == 2 && randomArmorMod != 0)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod1;
        }
		else if (randomCyborgMod == 2) {
            if(randomArmorMod != 2)
			characterMods.cyborgMod = CharacterMods.CyborgMod.mod3;
            else if (randomArmorMod == 2 && randomArmorMod != 0)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod1;
            else if (randomArmorMod == 0 && randomArmorMod != 1)
                characterMods.cyborgMod = CharacterMods.CyborgMod.mod2;
        }
		if (randomDNAMod == 0) {
			characterMods.DNAmod = CharacterMods.DNAMod.mod1;
		}
		else if (randomDNAMod== 1) {
			characterMods.DNAmod = CharacterMods.DNAMod.mod2;
		}
		else if (randomDNAMod == 2) {
			characterMods.DNAmod = CharacterMods.DNAMod.mod3;
		}
		if (randomGunMod == 0) {
			characterMods.gunMod = CharacterMods.GunMod.mod1;
		}
		else if (randomGunMod== 1) {
			characterMods.gunMod = CharacterMods.GunMod.mod2;
		}
		else if (randomGunMod == 2) {
			characterMods.gunMod = CharacterMods.GunMod.mod3;
		}
		if (randomMeleeMod == 0) {
			characterMods.meleeMod = CharacterMods.MeleeMod.mod1;
		}
		else if (randomMeleeMod== 1) {
			characterMods.meleeMod = CharacterMods.MeleeMod.mod2;
		}
		else if (randomMeleeMod == 2) {
			characterMods.meleeMod = CharacterMods.MeleeMod.mod3;
		}
		if (randomGrenadeMod == 0) {
			characterMods.grenadeMod = CharacterMods.GrenadeMod.mod1;
		}
		else if (randomGrenadeMod== 1) {
			characterMods.grenadeMod = CharacterMods.GrenadeMod.mod2;
		}
		else if (randomGrenadeMod == 2) {
			characterMods.grenadeMod = CharacterMods.GrenadeMod.mod3;
		}
		if (randomSuperAbility == 0) {
			characterMods.super = CharacterMods.Super.ability1;
		}
		else if (randomSuperAbility == 1) {
			characterMods.super = CharacterMods.Super.ability2;

		}
		else if (randomSuperAbility == 2) {
			characterMods.super = CharacterMods.Super.ability3;
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
