﻿using UnityEngine;
using System.Collections;

public class GameShowAttributes : MonoBehaviour {
	public enum Gender {Male, Female}
	public Gender gender;
	public enum SkinColor {White, Black, Hispanic}
	public SkinColor skinColor;
	public enum RaceSkills {Skill1, Skill2, Skill3}
	public RaceSkills raceSkills;

	
	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("GameShowGender") == 1)
            gender = Gender.Male;
        else if (PlayerPrefs.GetInt("GameShowGender") == 2)
            gender = Gender.Female;

        if (PlayerPrefs.GetInt("GameShowSkinColor") == 1)
            skinColor = SkinColor.Black;
        else if (PlayerPrefs.GetInt("GameShowSkinColor") == 2)
            skinColor = SkinColor.White;
        else if (PlayerPrefs.GetInt("GameShowSkinColor") == 3)
            skinColor = SkinColor.Hispanic;

        if (PlayerPrefs.GetInt("GameShowRaceSkills") == 1)
            raceSkills = RaceSkills.Skill1;
        else if (PlayerPrefs.GetInt("GameShowRaceSkills") == 2)
            raceSkills = RaceSkills.Skill2;
        else if (PlayerPrefs.GetInt("GameShowRaceSkills") == 3)
            raceSkills = RaceSkills.Skill3;
       



    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
