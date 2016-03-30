﻿using UnityEngine;
using System.Collections;

public class CharacterVisuals : MonoBehaviour {

    /// <summary>
    /// MOD 1 is head,
    /// MOD 2 is body,
    /// MOD 3 is arm or Leg
    /// </summary>
    public CharacterMods charMods;
  
    public CharacterAttributes charAttr;

    public GameObject femaleSkinColor1;
    public GameObject femaleSkinColor2;
    public GameObject femaleSkinColor3;

    public GameObject skinColor1;
    public GameObject skinColor2;
    public GameObject skinColor3;
    public GameObject femaleHead;
    public GameObject maleHead;
    public GameObject femaleChest;
    public GameObject maleChest;

    public GameObject armorMod1;
    public GameObject armorMod2;
    public GameObject armorMod3;

    public GameObject femaleArmorMod1;
    public GameObject femaleArmorMod2;
    public GameObject femaleArmorMod3;

    public GameObject cyborgMod1;
    public GameObject cyborgMod2;
    public GameObject cyborgMod3;

    public GameObject femaleCyborgMod1;
    public GameObject femaleCyborgMod2;
    public GameObject femaleCyborgMod3;

   // public GameObject DNAMod1;
  //  public GameObject DNAMod2;
 //   public GameObject DNAMod3;

    public GameObject gunMod1;
    public GameObject gunMod2;
    public GameObject gunMod3;

   // public GameObject meleeMod1;
  //  public GameObject meleeMod2;
  //  public GameObject meleeMod3;

    public GameObject grenadeMod1;
    public GameObject grenadeMod2;
    public GameObject grenadeMod3;

  //  public GameObject super1;
  //  public GameObject super2;
  //  public GameObject super3;

	// Use this for initialization
	public void RollVisuals () {
        /*   Additional Scripting needed for visuals as grenades are tied into attack
        if (charMods.grenadeMod == CharacterMods.GrenadeMod.mod1)
        {
            grenadeMod1.SetActive(true);
            grenadeMod2.SetActive(false);
            grenadeMod3.SetActive(false);
        }
        else if (charMods.grenadeMod == CharacterMods.GrenadeMod.mod2)
        {
            grenadeMod1.SetActive(false);
            grenadeMod2.SetActive(true);
            grenadeMod3.SetActive(false);
        }
        else if (charMods.grenadeMod == CharacterMods.GrenadeMod.mod3)
        {
            grenadeMod1.SetActive(false);
            grenadeMod2.SetActive(false);
            grenadeMod3.SetActive(true);
        }
        */
        if (charAttr.gender == CharacterAttributes.Gender.Male)
        {
            maleHead.SetActive(true);
            femaleHead.SetActive(false);
            maleChest.SetActive(true);
            femaleChest.SetActive(false);

            femaleArmorMod1.SetActive(false);
            femaleArmorMod2.SetActive(false);
            femaleArmorMod3.SetActive(false);

            femaleCyborgMod1.SetActive(false);
            femaleCyborgMod2.SetActive(false);
            femaleCyborgMod3.SetActive(false);

            if (charMods.armorMod == CharacterMods.ArmorMod.mod1)
            {
                armorMod1.SetActive(true);
                armorMod2.SetActive(false);
                armorMod3.SetActive(false);
            }
            else if (charMods.armorMod == CharacterMods.ArmorMod.mod2)
            {
                armorMod1.SetActive(false);
                armorMod2.SetActive(true);
                armorMod3.SetActive(false);
            }
            else if (charMods.armorMod == CharacterMods.ArmorMod.mod3)
            {
                armorMod1.SetActive(false);
                armorMod2.SetActive(false);
                armorMod3.SetActive(true);
            }


            if (charMods.cyborgMod == CharacterMods.CyborgMod.mod1)
            {
                cyborgMod1.SetActive(true);
                cyborgMod2.SetActive(false);
                cyborgMod3.SetActive(false);
            }
            else if (charMods.cyborgMod == CharacterMods.CyborgMod.mod2)
            {
                cyborgMod1.SetActive(false);
                cyborgMod2.SetActive(true);
                cyborgMod3.SetActive(false);
            }
            else if (charMods.cyborgMod == CharacterMods.CyborgMod.mod3)
            {
                cyborgMod1.SetActive(false);
                cyborgMod2.SetActive(false);
                cyborgMod3.SetActive(true);
            }
        }
        else if(charAttr.gender == CharacterAttributes.Gender.Female)
        {
            maleHead.SetActive(false);
            femaleHead.SetActive(true);
            maleChest.SetActive(false);
            femaleChest.SetActive(true);

            armorMod1.SetActive(false);
            armorMod2.SetActive(false);
            armorMod3.SetActive(false);

            cyborgMod1.SetActive(false);
            cyborgMod2.SetActive(false);
            cyborgMod3.SetActive(false);
            if (charMods.armorMod == CharacterMods.ArmorMod.mod1)
            {
                femaleArmorMod1.SetActive(true);
                femaleArmorMod2.SetActive(false);
                femaleArmorMod3.SetActive(false);
            }
            else if (charMods.armorMod == CharacterMods.ArmorMod.mod2)
            {
                femaleArmorMod1.SetActive(false);
                femaleArmorMod2.SetActive(true);
                femaleArmorMod3.SetActive(false);
            }
            else if (charMods.armorMod == CharacterMods.ArmorMod.mod3)
            {
                femaleArmorMod1.SetActive(false);
                femaleArmorMod2.SetActive(false);
                femaleArmorMod3.SetActive(true);
            }


            if (charMods.cyborgMod == CharacterMods.CyborgMod.mod1)
            {
                femaleCyborgMod1.SetActive(true);
                femaleCyborgMod2.SetActive(false);
                femaleCyborgMod3.SetActive(false);
            }
            else if (charMods.cyborgMod == CharacterMods.CyborgMod.mod2)
            {
                femaleCyborgMod1.SetActive(false);
                femaleCyborgMod2.SetActive(true);
                femaleCyborgMod3.SetActive(false);
            }
            else if (charMods.cyborgMod == CharacterMods.CyborgMod.mod3)
            {
                femaleCyborgMod1.SetActive(false);
                femaleCyborgMod2.SetActive(false);
                femaleCyborgMod3.SetActive(true);
            }
        }

        /*   Additional scripting needed as GunMods are tied into attacks
        if (charMods.gunMod == CharacterMods.GunMod.mod1)
        {
            gunMod1.SetActive(true);
            gunMod2.SetActive(false);
            gunMod3.SetActive(false);
        }
        else if (charMods.gunMod == CharacterMods.GunMod.mod2)
        {
            gunMod1.SetActive(false);
            gunMod2.SetActive(true);
            gunMod3.SetActive(false);
        }
        else if (charMods.gunMod == CharacterMods.GunMod.mod3)
        {
            gunMod1.SetActive(false);
            gunMod2.SetActive(false);
            gunMod3.SetActive(true);
        }
        */

       

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}