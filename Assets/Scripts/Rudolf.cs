using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rudolf : MonoBehaviour {

    // Use this for initialization
    public bool sendRegalo;
    public GameObject Arbol;
    public GameObject Exit;
	void Start () {
        sendRegalo = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!sendRegalo)
        {
            if (Vector2.Distance(transform.position, Arbol.transform.position) >= 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, Arbol.transform.position, 5 * Time.deltaTime);
            }
        }
        else
        {
            if (Vector2.Distance(transform.position, Exit.transform.position) >= 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, Exit.transform.position, 5 * Time.deltaTime);
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
