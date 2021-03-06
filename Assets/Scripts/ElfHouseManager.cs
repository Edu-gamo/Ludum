﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElfHouseManager : MonoBehaviour {

    public int elfsWorking = 0;
    public int elfsNeeded = 10;

    private float workCounter = 0;
    public float maxWorkTime = 30;
    public float minWorkTime = 10;
    public int presentIncrement = 2;

    private Text elfsText;

    // Use this for initialization
    void Start () {

        elfsText = GetComponentInChildren<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        workCounter += Time.deltaTime;

        if (elfsWorking > 0) {

            if (workCounter >= maxWorkTime) {

                workCounter = 0;
                GameManager.regalos += presentIncrement;

            }

        } else {

            if (workCounter >= 60) {

                workCounter = 0;
                GameManager.regalos += presentIncrement;

            }

        }

        elfsText.text = elfsWorking.ToString();

    }

    public bool AddElf() {

        if (maxWorkTime > minWorkTime) {
            elfsWorking++;
            if (elfsWorking % elfsNeeded == 0) maxWorkTime--;
            return true;
        }
        return false;

    }
}
