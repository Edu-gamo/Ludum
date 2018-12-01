using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private GameObject player;
    private Vector3 playerPos, movement;
    public float camSpeed = 5;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {

        movement = player.transform.position - transform.position;
        movement.z = 0;
        movement *= camSpeed * Time.deltaTime;

        transform.position += movement;

    }
}
