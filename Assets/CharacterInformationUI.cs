using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterInformationUI : MonoBehaviour {
	public CharacterStats charStats;
	public CharacterAttributes charAttr;
	public CharacterMods charMods;
	public Text HP;
	public Text meleeDamage;
	public Text gunDamage;	
	public Text bulletRange;
	public Text bulletSpeed;
	public Text firingSpeed;
	public Text accuracy;
	public Text totalAmmo;
	public Text movementSpeed;
	public Text jumpHeight;
	string defaultHP;
	string defaultMeleeDamage;
	string defaultGunDamage;
	string defaultBulletRange;
	string defaultFiringSpeed;
	string defaultAccuracy;
	string defaultTotalAmmo;
	string defaultMovementSpeed;
	string defaultJumpHeight;
	string defaultBulletSpeed;
	public Text gender;
	public Text skinColor;
	public Text raceSkills;
	public Text armor;
	public Text cyborg;
	public Text DNA; 
	public Text gun;
	public Text melee;
	public Text grenade;
	public Text super;

	string defArmor;
	string defCyborg;
	string defDNA;
	string defGun;
	string defMelee;
	string defGrenade;
	string defSuper;
	// Use this for initialization
	void Start () {
		defaultHP = HP.text;
		defaultMeleeDamage = meleeDamage.text;
		defaultGunDamage = gunDamage.text;
		defaultBulletRange = bulletRange.text;
		defaultBulletSpeed = bulletSpeed.text;
		defaultFiringSpeed = firingSpeed.text;
		defaultAccuracy = accuracy.text;
		defaultTotalAmmo = totalAmmo.text;
		defaultMovementSpeed = movementSpeed.text;
		defaultJumpHeight = jumpHeight.text;
		defArmor = armor.text;
		defCyborg = cyborg.text;
		defDNA = DNA.text;
		defGun = gun.text;
		defMelee = melee.text;
		defGrenade = grenade.text;
		defSuper = super.text;
		StartStats ();
	}
	public void StartStats(){
		HP.text = defaultHP + charStats.HP.ToString ();
		meleeDamage.text = defaultMeleeDamage + charStats.meleeDamage.ToString ();
		gunDamage.text = defaultGunDamage + charStats.gunDamage.ToString ();
		bulletRange.text = defaultBulletRange + charStats.bulletRange.ToString ();
		bulletSpeed.text = defaultBulletSpeed + charStats.bulletSpeed.ToString ();
		firingSpeed.text = defaultFiringSpeed + charStats.firingSpeed.ToString ();
		accuracy.text = defaultAccuracy + charStats.accuracy.ToString ();
		totalAmmo.text = defaultTotalAmmo + charStats.totalAmmo.ToString ();
		movementSpeed.text = defaultMovementSpeed + charStats.movementSpeed.ToString ();
		jumpHeight.text = defaultJumpHeight + charStats.jumpHeight.ToString ();
	}
	// Update is called once per frame
	public void DisplayStats () {
		HP.text = defaultHP + charStats.HP.ToString ();
		meleeDamage.text = defaultMeleeDamage + charStats.meleeDamage.ToString ();
		gunDamage.text = defaultGunDamage + charStats.gunDamage.ToString ();
		bulletRange.text = defaultBulletRange + charStats.bulletRange.ToString ();
		bulletSpeed.text = defaultBulletSpeed + charStats.bulletSpeed.ToString ();
		firingSpeed.text = defaultFiringSpeed + charStats.firingSpeed.ToString ();
		accuracy.text = defaultAccuracy + charStats.accuracy.ToString ();
		totalAmmo.text = defaultTotalAmmo + charStats.totalAmmo.ToString ();
		movementSpeed.text = defaultMovementSpeed + charStats.movementSpeed.ToString ();
		jumpHeight.text = defaultJumpHeight + charStats.jumpHeight.ToString ();
		gender.text = charAttr.gender.ToString ();
		skinColor.text = charAttr.skinColor.ToString ();
		raceSkills.text = charAttr.raceSkills.ToString ();
		armor.text = defArmor + charMods.armorMod.ToString ();
		cyborg.text = defCyborg + charMods.cyborgMod.ToString ();
		DNA.text = defDNA + charMods.DNAmod.ToString ();
		gun.text = defGun + charMods.gunMod.ToString ();
		melee.text = defMelee + charMods.meleeMod.ToString ();
		grenade.text = defGrenade + charMods.grenadeMod.ToString ();
		super.text = defSuper + charMods.super.ToString ();
	}
}
