using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : MonoBehaviour {

    private Transform Player;

    public GameObject[] nodes;
    public GameObject[] nodesFromNode1;
    public GameObject[] nodesFromNode2;
    public GameObject[] nodesFromNode3;
    public GameObject[] nodesFromNode4;
    public GameObject[] nodesFromNode5;
    public GameObject[] nodesFromNode6;
    public GameObject[] nodesFromNode7;
    int i = 0;
    int lastI = 0;
    float shortestDist;
    public int timeCounter;
    public int node;

    public float randomMov;

    private Animator anim;

    // Use this for initialization

    private void Awake()
    {
   
        shortestDist = Mathf.Infinity;
        for (int i = 0; i < nodes.Length; i++)
        {
            float distance = Vector2.Distance(transform.position, nodes[i].transform.position);
            if (distance < shortestDist)
            {
                shortestDist = distance;
                node = i;
            }
        }
        randomMov = Random.Range(200, 500);
    }
    void Start () {
       
        timeCounter = 0;
       
        Player = GameObject.Find("Player").GetComponent<Transform>();
        //Debug.Log("Nodo 0 " + Vector2.Distance(transform.position, nodes[0].transform.position));
        //Debug.Log("Nodo 1 " + Vector2.Distance(transform.position, nodes[1].transform.position));

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (node) { 
            case 0:
            if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
            {
                if (Vector2.Distance(transform.position, nodesFromNode1[i].transform.position) > 0)
                {
                    transform.position = Vector2.MoveTowards(transform.position, nodesFromNode1[i].transform.position, 3 * Time.deltaTime);
                }
            }
                if (Vector2.Distance(transform.position, nodesFromNode1[i].transform.position) == 0)
                {
                    i++;
                    timeCounter = 0;
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
               
                else
                {
                    timeCounter++;
                }
              
                break;
            case 1:
                if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode2[i].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode2[i].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode2[i].transform.position) == 0)
                {
                    if (timeCounter > 200)
                    {
                        i++;
                        timeCounter = 0;
                    }
                    else
                    {
                        timeCounter++;
                    }
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                break;
            case 2:
                if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode3[i].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode3[i].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode3[i].transform.position) == 0)
                {
                    if (timeCounter > 200)
                    {
                        i++;
                        timeCounter = 0;
                    }
                    else
                    {
                        timeCounter++;
                    }
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                break;
            case 3:
                if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode4[i].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode4[i].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode4[i].transform.position) == 0)
                {
                    if (timeCounter > 200)
                    {
                        i++;
                        timeCounter = 0;
                    }
                    else
                    {
                        timeCounter++;
                    }
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                break;
            case 4:
                if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode5[i].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode5[i].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode5[i].transform.position) == 0)
                {
                    if (timeCounter > 200)
                    {
                        i++;
                        timeCounter = 0;
                    }
                    else
                    {
                        timeCounter++;
                    }
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                break;
            case 5:
                if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode6[i].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode6[i].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode6[i].transform.position) == 0)
                {
                    if (timeCounter > 200)
                    {
                        i++;
                        timeCounter = 0;
                    }
                    else
                    {
                        timeCounter++;
                    }
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                break;
            case 6:
                if (Vector2.Distance(transform.position, nodes[node].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode7[i].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode7[i].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode7[i].transform.position) == 0)
                {
                    if (timeCounter > 200)
                    {
                        i++;
                        timeCounter = 0;
                    }
                    else
                    {
                        timeCounter++;
                    }
                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                break;
        }

        if(timeCounter == 0) {
            anim.SetBool(anim.GetParameter(0).name, true);
        } else {
            anim.SetBool(anim.GetParameter(0).name, false);
        }

    }
    
 
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                PlayerController.ammo++;
                Destroy(this.gameObject);
            }
        }
      
    }
    
}
