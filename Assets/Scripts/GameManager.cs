using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int regalos;
    public static bool gamePaused;
	// Use this for initialization
	void Start () {

        regalos = 50;
        gamePaused = false;

    }
	
	// Update is called once per frame
	void Update () {
		if(regalos == 0)
        {
            //game over
        }
	}
}
