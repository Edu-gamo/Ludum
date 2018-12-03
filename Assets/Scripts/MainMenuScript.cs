using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public void LoadScene(int index) {
        if (GameManager.gamePaused) ResumeGame();
        SceneManager.LoadScene(index);
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

}
