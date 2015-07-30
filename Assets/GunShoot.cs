using UnityEngine;
using System.Collections;

public class GunShoot : MonoBehaviour {

	public bool isGunActive = false;
	public bool isAutomatic = false;
	public float gunShotDistance = 500f;
	public float gunShotRate;
	public float gunShotSpeed = 1f;
	public float bulletMaxNumber;
	public bool isGrenade = false;

	//public float bulletStartingDistance = 1f;
//	public float bulletStartingHeight = 0.5f;

	public GameObject[] bulletList;
	public GunShotMovement[] gunShotMovement;
	public PlayerMovement playerMovement;
	private float nextFire;
	bool reset;
	int n = 0;

	public GameObject facingLeft; //left facing bullet to match rotation when facing left
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		//if(Input.GetButtonDown("Fire2")){
			if(playerMovement.grenade == true){
				if (Time.time > nextFire) {
					nextFire = Time.time + gunShotRate;
					if(n < bulletMaxNumber)
						n = n + 1;
					else if(n == bulletMaxNumber)
						n = 0;
					//	if(reset == false){
					//	gunShotMovement[n].SendMessage("ResetObject");
					//	reset = true;
					//}
					Vector3 pos = transform.position;
					
					
					
					if(playerMovement.isFacingRight == true){
						
						gunShotMovement[n].FireLeft ();
					int rand = playerMovement.randomMoveNumber;
					playerMovement.anim.SetInteger("randomAttack", rand);
					playerMovement.anim.SetTrigger("throw");
					playerMovement.puppetControl.SendMessage("GunControl");
						//	pos.x = pos.x + bulletStartingDistance;
						//	pos.y = pos.y + bulletStartingHeight;
						
						
					}
					else 
					{
						
						//	pos.x = pos.x - bulletStartingDistance;
						gunShotMovement[n].FireRight ();
						//pos.y = pos.y + bulletStartingHeight;
					}
					bulletList[n].transform.position = pos;
				}
			}
		//}


		if ((isAutomatic == true && Input.GetButton("Fire1")) || (isAutomatic == false && Input.GetButtonDown ("Fire1")))
			//if(Input.GetMouseButton(0))
		{
			reset = false;

			if(playerMovement.weaponNumber == 2 && isGrenade == false){
		
				if(isGunActive == true)
				{
					
					if (Time.time > nextFire) {
						nextFire = Time.time + gunShotRate;
						if(n < bulletMaxNumber)
							n = n + 1;
						else if(n == bulletMaxNumber)
							n = 0;
				//	if(reset == false){
					//	gunShotMovement[n].SendMessage("ResetObject");
					//	reset = true;
					//}
					Vector3 pos = transform.position;

						
						
						if(playerMovement.isFacingRight == true){

							gunShotMovement[n].FireLeft ();
					//	pos.x = pos.x + bulletStartingDistance;
					//	pos.y = pos.y + bulletStartingHeight;
						
							
						}
						else 
						{

					//	pos.x = pos.x - bulletStartingDistance;
							gunShotMovement[n].FireRight ();
						//pos.y = pos.y + bulletStartingHeight;
						}
					bulletList[n].transform.position = pos;
					}
				}
				
				
				
				


		}
		else
			reset = false;
	
	}
	}
}
