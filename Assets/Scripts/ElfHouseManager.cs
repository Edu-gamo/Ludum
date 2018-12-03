using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElfHouseManager : MonoBehaviour {

    public int elfsWorking = 0;
    public int elfsNeeded = 10;

    private float workCounter = 0;
    public float maxWorkTime = 30;
    public float minWorkTime = 10;
    public int presentIncrement = 1;

    private Text elfsText;

    // Use this for initialization
    void Start () {

        elfsText = GetComponentInChildren<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        if (elfsWorking > 0) {

            workCounter += Time.deltaTime;

            if (workCounter >= maxWorkTime) {

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
