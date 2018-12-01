using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour {

    private Rigidbody2D rb;
    private Transform  Target;
    public float vel;
   
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Target = GameObject.Find("Tree").GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {
        //If es oleada 1..
        //La velocidad de la oleada 
        vel = 1f;
        if(Vector2.Distance(transform.position,Target.position) > 0){
            transform.position = Vector2.MoveTowards(transform.position, Target.position, vel * Time.deltaTime);
        }

        //Rotacion hacia el objeto
        Vector2 direccion = Target.gameObject.transform.position - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tree")
        {
            GameManager.regalos--;
            Destroy(gameObject);
        }
    }
}
