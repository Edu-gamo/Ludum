using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ui : MonoBehaviour {


    public Text municionUI;
    public Text regalosUI;
    public Text roundUI;
    public Text regalospararobarUI;
    int ronda;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
       
        ronda = Spawn.round + 1;
        municionUI.text = "" + PlayerController.ammo;

        regalosUI.text = + GameManager.regalos +"\\"+ Rudolf.presentToSteal;
   
        roundUI.text = "ROUND " + ronda;
    }
}
