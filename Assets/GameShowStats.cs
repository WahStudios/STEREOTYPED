using UnityEngine;
using System.Collections;

public class GameShowStats : MonoBehaviour {



    public int HP = 25;
    public int meleeDamage = 1;
    public int gunDamage = 1;
    public int bulletRange = 1;
    public int bulletSpeed = 1;
    public int firingSpeed = 1;
    public int accuracy = 1;
    public int totalAmmo = 5;
    public int movementSpeed = 1;
    public int jumpHeight = 1;

    void Start()
    {
        HP = PlayerPrefs.GetInt("GameShowCharacterHP", HP);
        meleeDamage = PlayerPrefs.GetInt("GameShowCharacterMeleeDamage", meleeDamage);
        gunDamage = PlayerPrefs.GetInt("GameShowCharacterGunDamage", gunDamage);
        bulletRange = PlayerPrefs.GetInt("GameShowCharacterBulletRange", bulletRange);
        firingSpeed = PlayerPrefs.GetInt("GameShowCharacterFiringSpeed", firingSpeed);
        accuracy = PlayerPrefs.GetInt("GameShowCharacterAccuracy", accuracy);
        bulletSpeed = PlayerPrefs.GetInt("GameShowCharacterBulletSpeed", bulletSpeed);
        totalAmmo = PlayerPrefs.GetInt("GameShowCharacterTotalAmmo", totalAmmo);
        movementSpeed = PlayerPrefs.GetInt("GameShowCharacterMovementSpeed", movementSpeed);
        // -- need to set up stats below first
        //PlayerPrefs.GetInt("GameShowCharacterAmmoClip", ammoClip);
        // PlayerPrefs.GetInt("GameShowCharacterArmor", armor);
    }



}
