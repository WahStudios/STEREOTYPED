using UnityEngine;
using System.Collections;

public class StatModifiers : MonoBehaviour {

    public GunShoot gunShoot;
    public PlayerMovement playerMovement;
    public float jumpHeightModifier = 0.4f;
    public float movementSpeedModifier = 0.4f;
    public float bulletSpeedModifier = 0.4f;
    public float bulletRangeModifier = 0.4f;
    public float firingSpeedModifier = 4f;
    

	// Use this for initialization
	void Start () {
       playerMovement.jumpHeightModifier = jumpHeightModifier;
        playerMovement.speedForceModifier = movementSpeedModifier;
        gunShoot.gunShootDistanceModifier = bulletRangeModifier;
        gunShoot.gunShootRateModifier = firingSpeedModifier;
        gunShoot.gunShootSpeedModifier = bulletSpeedModifier;
        
       
	}
	
    public void ApplyModifiers()
    {
        playerMovement.jumpHeightModifier = jumpHeightModifier;
        playerMovement.speedForceModifier = movementSpeedModifier;
        gunShoot.gunShootDistanceModifier = bulletRangeModifier;
        gunShoot.gunShootRateModifier = firingSpeedModifier;
        gunShoot.gunShootSpeedModifier = bulletSpeedModifier;
        gunShoot.DelayedStart();
        playerMovement.DelayedStart();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
