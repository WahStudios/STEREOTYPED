using UnityEngine;
using System.Collections;

public class CharacterAttributes : MonoBehaviour {
	public enum Gender {Male, Female}
	public Gender gender;
	public enum SkinColor {White, Black, Hispanic}
	public SkinColor skinColor;
	public enum RaceSkills {Skill1, Skill2, Skill3}
	public RaceSkills raceSkills;

	public int maxSkinColors = 3;
	public int maxRaceSkills = 3;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
