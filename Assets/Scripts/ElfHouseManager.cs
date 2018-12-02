using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfHouseManager : MonoBehaviour {

    public int elfsWorking = 0;

    private float workCounter = 0;
    public float maxWorkTime = 30;
    public float minWorkTime = 10;
    public int presentIncrement = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (elfsWorking > 0) {

            workCounter += Time.deltaTime;

            if (workCounter >= maxWorkTime) {

                workCounter = 0;
                GameManager.regalos += presentIncrement;

            }

            Debug.Log(workCounter + " : " + elfsWorking + " : " + maxWorkTime);

        }
		
	}

    public bool AddElf() {

        if (maxWorkTime > minWorkTime) {
            elfsWorking++;
            if (elfsWorking % 5 == 0) maxWorkTime--;
            return true;
        }
        return false;

    }
}
