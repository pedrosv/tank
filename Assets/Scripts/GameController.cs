using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        showScore();
    }

    private void showScore()
    {
        scoreText.text = "Score: " + PlayerStats.Kills;
    }
}
