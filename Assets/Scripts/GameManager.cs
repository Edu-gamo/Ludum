﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public static int regalos = 30;
    public static bool gamePaused = false;
    // Use this for initialization

    // Update is called once per frame
    void Update () {
		if(regalos <= 0)
        {
            SceneManager.LoadScene(3);
        }
	}
}
