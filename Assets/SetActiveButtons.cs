using UnityEngine;
using System.Collections;

public class SetActiveButtons : MonoBehaviour {
    public GameObject char1Button;
    public GameObject char2Button;
	// Use this for initialization
	public void SetActiveButton () {
        char1Button.SetActive(true);
        char2Button.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
