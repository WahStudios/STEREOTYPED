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
		HP.text = charStats.HP.ToString ();
		meleeDamage.text = charStats.meleeDamage.ToString ();
		gunDamage.text = charStats.gunDamage.ToString ();
		bulletRange.text =  charStats.bulletRange.ToString ();
		bulletSpeed.text = charStats.bulletSpeed.ToString ();
		firingSpeed.text = charStats.firingSpeed.ToString ();
		accuracy.text =charStats.accuracy.ToString ();
		totalAmmo.text = charStats.totalAmmo.ToString ();
		movementSpeed.text =  charStats.movementSpeed.ToString ();
		jumpHeight.text = charStats.jumpHeight.ToString ();
	}
	// Update is called once per frame
	public void DisplayStats () {
		HP.text =charStats.HP.ToString ();
		meleeDamage.text = charStats.meleeDamage.ToString ();
		gunDamage.text =  charStats.gunDamage.ToString ();
		bulletRange.text =  charStats.bulletRange.ToString ();
		bulletSpeed.text =  charStats.bulletSpeed.ToString ();
		firingSpeed.text = charStats.firingSpeed.ToString ();
		accuracy.text = charStats.accuracy.ToString ();
		totalAmmo.text = charStats.totalAmmo.ToString ();
		movementSpeed.text = charStats.movementSpeed.ToString ();
		jumpHeight.text = charStats.jumpHeight.ToString ();
		gender.text = charAttr.gender.ToString ();
		skinColor.text = charAttr.skinColor.ToString ();
		raceSkills.text = charAttr.raceSkills.ToString ();
		armor.text = charMods.armorMod.ToString ();
		cyborg.text =charMods.cyborgMod.ToString ();
		DNA.text =  charMods.DNAmod.ToString ();
		gun.text = charMods.gunMod.ToString ();
		melee.text = charMods.meleeMod.ToString ();
		grenade.text = charMods.grenadeMod.ToString ();
		super.text =  charMods.super.ToString ();
	}
}
