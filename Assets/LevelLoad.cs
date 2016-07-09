using UnityEngine;
using System.Collections;


public class LevelLoad : MonoBehaviour {

    public int levelToLoad = 3;
	// Use this for initialization
	void Start () {
	
	}
	public void LoadLevel()
    {
        Application.LoadLevel(levelToLoad);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
