using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
    public Text textRound;
    int ronda;
	// Use this for initialization
	void Start () {
        ronda = Spawn.round += 1;
    }
	
	// Update is called once per frame
	void Update () {
      
        textRound.text = "ROUND: "+ ronda;
	}
    public void back()
    {
        SceneManager.LoadScene(0);
    }
    public void playAgain()
    {
        SceneManager.LoadScene(2);

    }
    public void quiTting()
    {
        Application.Quit();
    }
}
