using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public GameObject titleScreen;
    public GameObject gameShowScreen;
    public GameObject char1;
    public GameObject char2;
    // Use this for initialization

    public void GameShow()
    {
        titleScreen.SetActive(false);
        gameShowScreen.SetActive(true);
        char1.SetActive(true);
        char2.SetActive(true);
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
