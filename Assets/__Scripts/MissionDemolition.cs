using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// TODO: You must set the values for the enum
public enum GameMode
{
    idle,
    playing, 
    levelEnd

}


// TODO: implement the MissionDemolition script
public class MissionDemolition : MonoBehaviour {

    static private MissionDemolition S;

    [Header("Set in Inspector")]
    public Text uitLEvel;
    public Text uitShots;
    public Text uitButton;
    public Vector3 castlePos;
    public GameObject[] castles;

    [Header("Set Dynamically")]
    public int level;
    public int levelMax;



	// Use this for initialization
	void Start ()
    {

    }
	
	void StartLevel()
    {

 
    }

    void UpdateGUI()
    {

    }

    void Update()
    {


    }

    void NextLevel()
    {

    }

    public void SwitchView(string eView = "")
    {

    }

    // Static method that allows code anywhere to increment shotsTaken
    public static void ShotFired()
    {

    }
}
