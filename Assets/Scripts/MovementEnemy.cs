using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour {

    private Rigidbody2D rb;
    private Transform  Target;
    public static float vel;

    public GameObject[] exits;
    public int exit;
    public float shortestDist;
    public int i = 0;
    public bool stealed = false;

    public int hp = 1;

    public ParticleSystem explosion;

    public GameObject objectStealed;
    public GameObject objectToInst;
    private void Awake() {
        shortestDist = Mathf.Infinity;
        for (int i = 0; i < exits.Length; i++) {
            float distance = Vector2.Distance(transform.position, exits[i].transform.position);
            if (distance < shortestDist) {
                shortestDist = distance;
                exit = i;
            }
        }
    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        Target = GameObject.Find("Tree").GetComponent<Transform>();
        objectStealed.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (hp <= 0) {
            Instantiate(explosion, transform.position, Quaternion.identity);
            if (stealed)
            {
                Instantiate(objectToInst, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }

        //If es oleada 1..
        //La velocidad de la oleada 
        if (!stealed) {
            //Velocidad del elfo
            vel = 1f;
            if (Vector2.Distance(transform.position, Target.position) > 0) {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, vel * Time.deltaTime);
            }
        } else {
            objectStealed.gameObject.SetActive(true);
            transform.position = Vector2.MoveTowards(transform.position, exits[exit].transform.position, 5 * Time.deltaTime);
        }

        //Rotacion hacia el objeto
        Vector2 direccion = Target.gameObject.transform.position - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);

        //Si llega al muro mas cercano despues de robar el regalo, muere
        if (Vector3.Distance(transform.position, exits[exit].transform.position) < 0.5f && stealed) Destroy(gameObject); 
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Tree") {
            GameManager.regalos--;
            stealed = true;
        }
    }
}
