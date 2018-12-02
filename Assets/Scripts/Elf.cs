﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : MonoBehaviour {

    private Transform Player;

    public GameObject[] nodes;
    public GameObject[] nodesFromNode1;
    public GameObject[] nodesFromNode2;
    int i = 0;
    int lastI = 0;
    float shortestDist;
    public int timeCounter;
    public int node;

    public float randomMov;
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
        Debug.Log("Nodo 0 " + Vector2.Distance(transform.position, nodes[0].transform.position));
        Debug.Log("Nodo 1 " + Vector2.Distance(transform.position, nodes[1].transform.position));


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
                    if(i == 4)
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