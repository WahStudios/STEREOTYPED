using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatIconsUI : MonoBehaviour {
    public int charNumber = 1;
    public CharacterStats char1Stats;
    public CharacterStats char2Stats;
    public CharacterStats char3Stats;
    public CharacterStats char4Stats;
    public Image meleeDamage1;
    public Image meleeDamage2;
    public Image meleeDamage3;
    public Image meleeDamage4;
    public Image meleeDamage5;
    public Image meleeDamage6;
    public Image meleeDamage7;
    public Image meleeDamage8;
    public Image meleeDamage9;
    public Image meleeDamage10;
    public Image gunDamage1;
    public Image gunDamage2;
    public Image gunDamage3;
    public Image gunDamage4;
    public Image gunDamage5;
    public Image gunDamage6;
    public Image gunDamage7;
    public Image gunDamage8;
    public Image gunDamage9;
    public Image gunDamage10;
    public Image bulletRange1;
    public Image bulletRange2;
    public Image bulletRange3;
    public Image bulletRange4;
    public Image bulletRange5;
    public Image bulletRange6;
    public Image bulletRange7;
    public Image bulletRange8;
    public Image bulletRange9;
    public Image bulletRange10;
    public Image bulletSpeed1;
    public Image bulletSpeed2;
    public Image bulletSpeed3;
    public Image bulletSpeed4;
    public Image bulletSpeed5;
    public Image bulletSpeed6;
    public Image bulletSpeed7;
    public Image bulletSpeed8;
    public Image bulletSpeed9;
    public Image bulletSpeed10;
    public Image firingSpeed1;
    public Image firingSpeed2;
    public Image firingSpeed3;
    public Image firingSpeed4;
    public Image firingSpeed5;
    public Image firingSpeed6;
    public Image firingSpeed7;
    public Image firingSpeed8;
    public Image firingSpeed9;
    public Image firingSpeed10;
    public Image accuracy1;
    public Image accuracy2;
    public Image accuracy3;
    public Image accuracy4;
    public Image accuracy5;
    public Image accuracy6;
    public Image accuracy7;
    public Image accuracy8;
    public Image accuracy9;
    public Image accuracy10;
    //  public Image totalAmmo1;
    //public Image totalAmmo2;
    // public Image totalAmmo3;
    public Image movementSpeed1;
    public Image movementSpeed2;
    public Image movementSpeed3;
    public Image movementSpeed4;
    public Image movementSpeed5;
    public Image movementSpeed6;
    public Image movementSpeed7;
    public Image movementSpeed8;
    public Image movementSpeed9;
    public Image movementSpeed10;

    public Image jumpHeight1;
    public Image jumpHeight2;
    public Image jumpHeight3;
    public Image jumpHeight4;
    public Image jumpHeight5;
    public Image jumpHeight6;
    public Image jumpHeight7;
    public Image jumpHeight8;
    public Image jumpHeight9;
    public Image jumpHeight10;

    public void RollCharacter()
    {
        if (charNumber == 1)
        {
            if (char1Stats.accuracy == 1)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = false;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 2)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 3)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 4)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 5)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 6)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 7)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 8)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 9)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = false;
            }
            else if (char1Stats.accuracy == 10)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = true;
            }
            //---------------------------------

            if (char1Stats.meleeDamage == 1)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = false;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 2)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 3)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 4)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 5)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 6)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 7)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 8)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 9)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = false;
            }
            else if (char1Stats.meleeDamage == 10)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = true;
            }
            //------------------------------------------
            if (char1Stats.gunDamage == 1)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = false;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 2)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 3)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 4)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 5)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 6)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 7)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 8)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 9)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = false;
            }
            else if (char1Stats.gunDamage == 10)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = true;
            }
            //---------------------------------------
            if (char1Stats.bulletRange == 1)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = false;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 2)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 3)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 4)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 5)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 6)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 7)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 8)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 9)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = false;
            }
            else if (char1Stats.bulletRange == 10)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = true;
            }
            //-----------------------------------
            if (char1Stats.bulletSpeed == 1)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = false;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 2)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 3)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 4)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 5)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 6)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 7)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 8)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 9)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = false;
            }
            else if (char1Stats.bulletSpeed == 10)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = true;
            }
            //------------------------------------
            if (char1Stats.firingSpeed == 1)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = false;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 2)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 3)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 4)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 5)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 6)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 7)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 8)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 9)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = false;
            }
            else if (char1Stats.firingSpeed == 10)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = true;
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
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 2)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed3.enabled = false;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 3)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 4)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 5)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 6)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 7)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 8)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 9)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = false;
            }
            else if (char1Stats.movementSpeed == 10)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = true;
            }
            //-----------------------------------------
            if (char1Stats.jumpHeight == 1)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = false;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 2)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 3)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 4)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 5)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 6)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 7)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 8)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 9)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = false;
            }
            else if (char1Stats.jumpHeight == 10)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = true;
            }

        }


        else if (charNumber == 2)
        {
            if (char2Stats.accuracy == 1)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = false;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 2)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 3)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 4)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 5)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 6)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 7)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 8)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 9)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = false;
            }
            else if (char2Stats.accuracy == 10)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = true;
            }
            //---------------------------------

            if (char2Stats.meleeDamage == 1)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = false;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 2)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 3)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 4)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 5)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 6)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 7)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 8)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 9)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = false;
            }
            else if (char2Stats.meleeDamage == 10)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = true;
            }
            //------------------------------------------
            if (char2Stats.gunDamage == 1)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = false;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 2)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 3)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 4)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 5)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 6)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 7)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 8)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 9)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = false;
            }
            else if (char2Stats.gunDamage == 10)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = true;
            }
            //---------------------------------------
            if (char2Stats.bulletRange == 1)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = false;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 2)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 3)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 4)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 5)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 6)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 7)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 8)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 9)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = false;
            }
            else if (char2Stats.bulletRange == 10)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = true;
            }
            //-----------------------------------
            if (char2Stats.bulletSpeed == 1)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = false;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 2)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 3)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 4)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 5)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 6)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 7)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 8)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 9)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = false;
            }
            else if (char2Stats.bulletSpeed == 10)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = true;
            }
            //------------------------------------
            if (char2Stats.firingSpeed == 1)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = false;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 2)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 3)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 4)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 5)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 6)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 7)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 8)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 9)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = false;
            }
            else if (char2Stats.firingSpeed == 10)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = true;
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
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 2)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed3.enabled = false;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 3)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 4)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 5)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 6)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 7)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 8)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 9)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = false;
            }
            else if (char2Stats.movementSpeed == 10)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = true;
            }
            //-----------------------------------------
            if (char2Stats.jumpHeight == 1)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = false;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 2)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 3)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 4)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 5)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 6)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 7)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 8)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 9)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = false;
            }
            else if (char2Stats.jumpHeight == 10)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = true;
            }
        }
        else if (charNumber == 3)
        {
            if (char3Stats.accuracy == 1)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = false;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 2)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 3)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 4)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 5)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 6)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 7)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 8)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 9)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = false;
            }
            else if (char3Stats.accuracy == 10)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = true;
            }
            //---------------------------------

            if (char3Stats.meleeDamage == 1)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = false;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 2)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 3)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 4)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 5)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 6)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 7)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 8)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 9)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = false;
            }
            else if (char3Stats.meleeDamage == 10)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = true;
            }
            //------------------------------------------
            if (char3Stats.gunDamage == 1)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = false;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 2)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 3)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 4)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 5)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 6)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 7)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 8)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 9)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = false;
            }
            else if (char3Stats.gunDamage == 10)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = true;
            }
            //---------------------------------------
            if (char3Stats.bulletRange == 1)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = false;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 2)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 3)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 4)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 5)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 6)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 7)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 8)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 9)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = false;
            }
            else if (char3Stats.bulletRange == 10)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = true;
            }
            //-----------------------------------
            if (char3Stats.bulletSpeed == 1)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = false;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 2)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 3)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 4)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 5)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 6)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 7)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 8)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 9)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = false;
            }
            else if (char3Stats.bulletSpeed == 10)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = true;
            }
            //------------------------------------
            if (char3Stats.firingSpeed == 1)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = false;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 2)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 3)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 4)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 5)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 6)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 7)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 8)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 9)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = false;
            }
            else if (char3Stats.firingSpeed == 10)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = true;
            }

            /*
            if (char3Stats.totalAmmo == 1)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = false;
                totalAmmo3.enabled = false;
            }
            else if (char3Stats.totalAmmo == 2)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
                totalAmmo3.enabled = false;
            }
            else if (char3Stats.totalAmmo == 3)
            {
                totalAmmo3.enabled = true;
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
            }
            */
            if (char3Stats.movementSpeed == 1)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = false;
                movementSpeed3.enabled = false;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 2)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed3.enabled = false;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 3)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 4)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 5)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 6)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 7)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 8)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 9)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = false;
            }
            else if (char3Stats.movementSpeed == 10)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = true;
            }
            //-----------------------------------------
            if (char3Stats.jumpHeight == 1)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = false;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 2)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 3)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 4)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 5)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 6)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 7)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 8)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 9)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = false;
            }
            else if (char3Stats.jumpHeight == 10)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = true;
            }
        }
        else if (charNumber == 4)
        {
            if (char4Stats.accuracy == 1)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = false;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 2)
            {
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy3.enabled = false;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 3)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = false;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 4)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = false;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 5)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = false;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 6)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = false;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 7)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = false;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 8)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = false;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 9)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = false;
            }
            else if (char4Stats.accuracy == 10)
            {
                accuracy3.enabled = true;
                accuracy1.enabled = true;
                accuracy2.enabled = true;
                accuracy4.enabled = true;
                accuracy5.enabled = true;
                accuracy6.enabled = true;
                accuracy7.enabled = true;
                accuracy8.enabled = true;
                accuracy9.enabled = true;
                accuracy10.enabled = true;
            }
            //---------------------------------

            if (char4Stats.meleeDamage == 1)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = false;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 2)
            {
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage3.enabled = false;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 3)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = false;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 4)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = false;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 5)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = false;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 6)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = false;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 7)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = false;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 8)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = false;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 9)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = false;
            }
            else if (char4Stats.meleeDamage == 10)
            {
                meleeDamage3.enabled = true;
                meleeDamage1.enabled = true;
                meleeDamage2.enabled = true;
                meleeDamage4.enabled = true;
                meleeDamage5.enabled = true;
                meleeDamage6.enabled = true;
                meleeDamage7.enabled = true;
                meleeDamage8.enabled = true;
                meleeDamage9.enabled = true;
                meleeDamage10.enabled = true;
            }
            //------------------------------------------
            if (char4Stats.gunDamage == 1)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = false;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 2)
            {
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage3.enabled = false;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 3)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = false;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 4)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = false;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 5)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = false;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 6)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = false;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 7)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = false;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 8)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = false;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 9)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = false;
            }
            else if (char4Stats.gunDamage == 10)
            {
                gunDamage3.enabled = true;
                gunDamage1.enabled = true;
                gunDamage2.enabled = true;
                gunDamage4.enabled = true;
                gunDamage5.enabled = true;
                gunDamage6.enabled = true;
                gunDamage7.enabled = true;
                gunDamage8.enabled = true;
                gunDamage9.enabled = true;
                gunDamage10.enabled = true;
            }
            //---------------------------------------
            if (char4Stats.bulletRange == 1)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = false;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 2)
            {
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange3.enabled = false;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 3)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = false;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 4)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = false;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 5)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = false;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 6)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = false;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 7)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = false;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 8)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = false;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 9)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = false;
            }
            else if (char4Stats.bulletRange == 10)
            {
                bulletRange3.enabled = true;
                bulletRange1.enabled = true;
                bulletRange2.enabled = true;
                bulletRange4.enabled = true;
                bulletRange5.enabled = true;
                bulletRange6.enabled = true;
                bulletRange7.enabled = true;
                bulletRange8.enabled = true;
                bulletRange9.enabled = true;
                bulletRange10.enabled = true;
            }
            //-----------------------------------
            if (char4Stats.bulletSpeed == 1)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = false;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 2)
            {
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed3.enabled = false;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 3)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = false;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 4)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = false;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 5)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = false;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 6)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = false;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 7)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = false;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 8)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = false;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 9)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = false;
            }
            else if (char4Stats.bulletSpeed == 10)
            {
                bulletSpeed3.enabled = true;
                bulletSpeed1.enabled = true;
                bulletSpeed2.enabled = true;
                bulletSpeed4.enabled = true;
                bulletSpeed5.enabled = true;
                bulletSpeed6.enabled = true;
                bulletSpeed7.enabled = true;
                bulletSpeed8.enabled = true;
                bulletSpeed9.enabled = true;
                bulletSpeed10.enabled = true;
            }
            //------------------------------------
            if (char4Stats.firingSpeed == 1)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = false;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 2)
            {
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed3.enabled = false;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 3)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = false;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 4)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = false;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 5)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = false;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 6)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = false;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 7)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = false;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 8)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = false;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 9)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = false;
            }
            else if (char4Stats.firingSpeed == 10)
            {
                firingSpeed3.enabled = true;
                firingSpeed1.enabled = true;
                firingSpeed2.enabled = true;
                firingSpeed4.enabled = true;
                firingSpeed5.enabled = true;
                firingSpeed6.enabled = true;
                firingSpeed7.enabled = true;
                firingSpeed8.enabled = true;
                firingSpeed9.enabled = true;
                firingSpeed10.enabled = true;
            }

            /*
            if (char4Stats.totalAmmo == 1)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = false;
                totalAmmo3.enabled = false;
            }
            else if (char4Stats.totalAmmo == 2)
            {
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
                totalAmmo3.enabled = false;
            }
            else if (char4Stats.totalAmmo == 3)
            {
                totalAmmo3.enabled = true;
                totalAmmo1.enabled = true;
                totalAmmo2.enabled = true;
            }
            */
            if (char4Stats.movementSpeed == 1)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = false;
                movementSpeed3.enabled = false;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 2)
            {
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed3.enabled = false;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 3)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = false;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 4)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = false;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 5)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = false;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 6)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = false;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 7)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = false;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 8)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = false;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 9)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = false;
            }
            else if (char4Stats.movementSpeed == 10)
            {
                movementSpeed3.enabled = true;
                movementSpeed1.enabled = true;
                movementSpeed2.enabled = true;
                movementSpeed4.enabled = true;
                movementSpeed5.enabled = true;
                movementSpeed6.enabled = true;
                movementSpeed7.enabled = true;
                movementSpeed8.enabled = true;
                movementSpeed9.enabled = true;
                movementSpeed10.enabled = true;
            }
            //-----------------------------------------
            if (char4Stats.jumpHeight == 1)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = false;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 2)
            {
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight3.enabled = false;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 3)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = false;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 4)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = false;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 5)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = false;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 6)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = false;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 7)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = false;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 8)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = false;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 9)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = false;
            }
            else if (char4Stats.jumpHeight == 10)
            {
                jumpHeight3.enabled = true;
                jumpHeight1.enabled = true;
                jumpHeight2.enabled = true;
                jumpHeight4.enabled = true;
                jumpHeight5.enabled = true;
                jumpHeight6.enabled = true;
                jumpHeight7.enabled = true;
                jumpHeight8.enabled = true;
                jumpHeight9.enabled = true;
                jumpHeight10.enabled = true;
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
