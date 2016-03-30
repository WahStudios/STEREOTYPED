using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatIconsUI : MonoBehaviour {
    public int charNumber = 1;
    public CharacterStats char1Stats;
    public CharacterStats char2Stats;
    public Image meleeDamage1;
    public Image meleeDamage2;
    public Image meleeDamage3;
    public Image gunDamage1;
    public Image gunDamage2;
    public Image gunDamage3;
    public Image bulletRange1;
    public Image bulletRange2;
    public Image bulletRange3;
    public Image bulletSpeed1;
    public Image bulletSpeed2;
    public Image bulletSpeed3;
    public Image firingSpeed1;
    public Image firingSpeed2;
    public Image firingSpeed3;
    public Image accuracy1;
    public Image accuracy2;
    public Image accuracy3;
  //  public Image totalAmmo1;
    //public Image totalAmmo2;
   // public Image totalAmmo3;
    public Image movementSpeed1;
    public Image movementSpeed2;
    public Image movementSpeed3;
    public Image jumpHeight1;
    public Image jumpHeight2;
    public Image jumpHeight3;

   public void RollCharacter()
    {
        if(charNumber == 1)
        {
            if(char1Stats.accuracy == 1)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = false;
                accuracy3.enabled = false;
            }
            else if(char1Stats.accuracy == 2)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy3.enabled = false;
            }
            else if(char1Stats.accuracy == 3)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
            }

            if (char1Stats.meleeDamage == 1)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = false;
                meleeDamage3.enabled = false;
            }
            else if (char1Stats.meleeDamage == 2)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage3.enabled = false;
            }
            else if (char1Stats.meleeDamage == 3)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
            }

            if (char1Stats.gunDamage == 1)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = false;
                gunDamage3.enabled = false;
            }
            else if (char1Stats.gunDamage == 2)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage3.enabled = false;
            }
            else if (char1Stats.gunDamage == 3)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
            }

            if (char1Stats.bulletRange == 1)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = false;
                bulletRange3.enabled = false;
            }
            else if (char1Stats.bulletRange == 2)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange3.enabled = false;
            }
            else if (char1Stats.bulletRange == 3)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
            }

            if (char1Stats.bulletSpeed == 1)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = false;
                bulletSpeed3.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 2)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed3.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 3)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
            }

            if (char1Stats.firingSpeed == 1)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = false;
                firingSpeed3.enabled = false;
            }
            else if (char1Stats.firingSpeed == 2)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed3.enabled = false;
            }
            else if (char1Stats.firingSpeed == 3)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
            }
            /*
            if (char1Stats.totalAmmo == 1)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = false;
                totalAmmo3.enabled = false;
            }
            else if (char1Stats.totalAmmo == 2)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
                totalAmmo3.enabled = false;
            }
            else if (char1Stats.totalAmmo == 3)
            {
                totalAmmo3.enabled = true;
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
            }
            */
            if (char1Stats.movementSpeed == 1)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = false;
                movementSpeed3.enabled = false;
            }
            else if (char1Stats.movementSpeed == 2)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed3.enabled = false;
            }
            else if (char1Stats.movementSpeed == 3)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
            }

            if (char1Stats.jumpHeight == 1)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = false;
                jumpHeight3.enabled = false;
            }
            else if (char1Stats.jumpHeight == 2)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight3.enabled = false;
            }
            else if (char1Stats.jumpHeight == 3)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
            }
        }


        else if(charNumber == 2)
        {
            if (char2Stats.accuracy == 1)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = false;
                accuracy3.enabled = false;
            }
            else if (char2Stats.accuracy == 2)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy3.enabled = false;
            }
            else if (char2Stats.accuracy == 3)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
            }

            if (char2Stats.meleeDamage == 1)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = false;
                meleeDamage3.enabled = false;
            }
            else if (char2Stats.meleeDamage == 2)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage3.enabled = false;
            }
            else if (char2Stats.meleeDamage == 3)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
            }

            if (char2Stats.gunDamage == 1)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = false;
                gunDamage3.enabled = false;
            }
            else if (char2Stats.gunDamage == 2)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage3.enabled = false;
            }
            else if (char2Stats.gunDamage == 3)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
            }

            if (char2Stats.bulletRange == 1)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = false;
                bulletRange3.enabled = false;
            }
            else if (char2Stats.bulletRange == 2)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange3.enabled = false;
            }
            else if (char2Stats.bulletRange == 3)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
            }

            if (char2Stats.bulletSpeed == 1)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = false;
                bulletSpeed3.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 2)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed3.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 3)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
            }

            if (char2Stats.firingSpeed == 1)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = false;
                firingSpeed3.enabled = false;
            }
            else if (char2Stats.firingSpeed == 2)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed3.enabled = false;
            }
            else if (char2Stats.firingSpeed == 3)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
            }
            /*
            if (char2Stats.totalAmmo == 1)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = false;
                totalAmmo3.enabled = false;
            }
            else if (char2Stats.totalAmmo == 2)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
                totalAmmo3.enabled = false;
            }
            else if (char2Stats.totalAmmo == 3)
            {
                totalAmmo3.enabled = true;
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
            }
            */
            if (char2Stats.movementSpeed == 1)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = false;
                movementSpeed3.enabled = false;
            }
            else if (char2Stats.movementSpeed == 2)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed3.enabled = false;
            }
            else if (char2Stats.movementSpeed == 3)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
            }

            if (char2Stats.jumpHeight == 1)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = false;
                jumpHeight3.enabled = false;
            }
            else if (char2Stats.jumpHeight == 2)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight3.enabled = false;
            }
            else if (char2Stats.jumpHeight == 3)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
            }
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
