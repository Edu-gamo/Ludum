using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rudolf : MonoBehaviour {

    // Use this for initialization
    public bool sendRegalo;
    public GameObject Arbol;
    public GameObject Exit;
    public static int presentToSteal;
	void Start () {
        sendRegalo = false;
        presentToSteal = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (!sendRegalo)
        {
            if (Vector2.Distance(transform.position, Arbol.transform.position) >= 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, Arbol.transform.position, 15 * Time.deltaTime);
            }
        }
        if (Vector2.Distance(transform.position, Arbol.transform.position) == 0)
        {
            sendRegalo = true;
            if (Spawn.round == 3)
            {
                GameManager.regalos -= presentToSteal;
            }
            if (Spawn.round == 6)
            {
                presentToSteal = 20;
                GameManager.regalos -= presentToSteal;
            }
            if (Spawn.round == 9 || Spawn.round == 12 || Spawn.round == 12
                || Spawn.round == 15 || Spawn.round == 18 || Spawn.round == 21
                || Spawn.round == 24 || Spawn.round == 27 || Spawn.round == 30)
            {
                presentToSteal = 30;
                GameManager.regalos -= presentToSteal;
            }
        }
        if (sendRegalo)
        {
            if (Vector2.Distance(transform.position, Exit.transform.position) >= 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, Exit.transform.position, 15 * Time.deltaTime);
            }
            if (Vector2.Distance(transform.position, Exit.transform.position) == 0)
            {
                Destroy(gameObject);
            }
        }
        
        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tree")
        {
            Debug.Log("hi");
        }


    }

}
