using UnityEngine;
using System.Collections;

public class aiming : MonoBehaviour {
	public PlayerMovement player;
//	public Texture2D cursorTexture;
	private Vector2 cursorHotspot;
	public Sprite sprite;
	// Use this for initialization
	void Start () {
		var croppedTexture = new Texture2D( (int)sprite.rect.width, (int)sprite.rect.height );
		
		var pixels = sprite.texture.GetPixels(  (int)sprite.textureRect.x, 
		                                      (int)sprite.textureRect.y, 
		                                      (int)sprite.textureRect.width, 
		                                      (int)sprite.textureRect.height );
		
		croppedTexture.SetPixels( pixels );
		croppedTexture.Apply();
		cursorHotspot = new Vector2 (croppedTexture.width / 2, croppedTexture.height / 2);
		Cursor.SetCursor(croppedTexture, cursorHotspot, CursorMode.Auto);
	}

	

	// Update is called once per frame
	void Update () {

		//rotation
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		if(player.isFacingRight == false){
		float angle = Mathf.Atan2(-mousePos.x, mousePos.y) * Mathf.Rad2Deg;
			angle = Mathf.Clamp (angle, 0, 180);
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
		}
		else
		{
			float angle = Mathf.Atan2(mousePos.x, mousePos.y) * Mathf.Rad2Deg;
			angle = Mathf.Clamp (angle, 0, 180);
			transform.rotation = Quaternion.Euler(new Vector3(0, 180, angle));
		}

		}


}
