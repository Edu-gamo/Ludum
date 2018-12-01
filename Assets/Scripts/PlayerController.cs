using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float axisX, axisY;
    public float speed = 10;
    private Vector2 movement;

    private Rigidbody2D rigid;

    public static int municion;

    // Use this for initialization
    void Start () {

        rigid = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {

        GetInputs();

        movement = new Vector2(axisX, axisY);
        movement *= speed * Time.deltaTime;
        
        rigid.MovePosition(rigid.position + movement);

    }

    void GetInputs() {
        
        axisX = Input.GetAxisRaw("Horizontal");
        axisY = Input.GetAxisRaw("Vertical");

    }
}
