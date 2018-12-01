using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ui : MonoBehaviour {


    public Text municionUI;
    public Text regalosUI;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        municionUI.text = "" + PlayerController.municion;

        regalosUI.text = "" + GameManager.regalos;
    }
}
