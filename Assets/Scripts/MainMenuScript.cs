using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public GameObject mute;
    public GameObject unmute;
	public void LoadScene(int index) {
        if (GameManager.gamePaused) ResumeGame();
        SceneManager.LoadScene(index);
    }
    private void Start()
    {
        if (GameObject.Find("MuteButton") != null)
        {
            unmute.gameObject.SetActive(false);
        }
    }
    public void ExitGame() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void PauseGame() {

        Time.timeScale = 0;
        GameManager.gamePaused = true;

    }

    public void ResumeGame() {

        Time.timeScale = 1;
        GameManager.gamePaused = false;

    }
    public void MuteSound()
    {
  
        AudioListener.pause = true;
        AudioListener.volume = 0;
        if (GameObject.Find("MuteButton") != null || GameObject.Find("UnmuteButton") != null)
        {
            unmute.gameObject.SetActive(true);
            mute.gameObject.SetActive(false);
        }
    }
    public void unmuteSound()
    {
        AudioListener.pause = false;
        AudioListener.volume = 1;
        if (GameObject.Find("MuteButton") != null || GameObject.Find("UnmuteButton") != null)
        {
            unmute.gameObject.SetActive(false);
            mute.gameObject.SetActive(true);
        }
    }
}
