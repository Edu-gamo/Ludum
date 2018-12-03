using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
    public Text textRound;
    public Text textResult;
    public GameObject santa;
    int ronda;
	// Use this for initialization
	void Start () {
        ronda = Spawn.round += 1;
        if (ronda >= 10) {
            textResult.text = "YOU WIN";
            santa.SetActive(false);
        } else {
            textResult.text = "GAME OVER";
            santa.SetActive(true);
        }
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
        GameManager.regalos = 30;
        SceneManager.LoadScene(2);

    }
    public void quiTting()
    {
        Application.Quit();
    }
}
