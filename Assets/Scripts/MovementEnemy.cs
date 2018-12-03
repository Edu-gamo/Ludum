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

    int way = 0;
    public GameObject[] nodes;
    public GameObject[] nodesFromNode1;
    public GameObject[] nodesFromNode2;
    public GameObject[] nodesFromNode3;
    public GameObject[] nodesFromNode4;
    public GameObject[] nodesFromNode5;
    public GameObject[] nodesFromNode6;
    public GameObject[] nodesFromNode7;
    public GameObject[] nodesFromNode8;
    public GameObject[] nodesFromNode9;
    public GameObject[] nodesFromNode10;
    public GameObject[] nodesFromNode11;
    public GameObject[] nodesFromNode12;
    public GameObject[] nodesFromNode13;
    public GameObject[] nodesFromNode14;
    public GameObject[] nodesFromNode15;
    public GameObject[] nodesFromNode17;
    public GameObject[] nodesFromNode16;
    public int nudes;
    float shortesNude;

    private SpriteRenderer sprRender;
    public Vector2 presentOffset = new Vector2(1.15f, 0.2f);
  
    private void Awake() {
        shortesNude = Mathf.Infinity;
        shortestDist = Mathf.Infinity;
        for (int i = 0; i < exits.Length; i++) {
            float distance = Vector2.Distance(transform.position, exits[i].transform.position);
            if (distance < shortestDist) {
                shortestDist = distance;
                exit = i;
            }
        }
        for(int i = 0; i < nodes.Length; i++)
        {
            float distance = Vector2.Distance(transform.position, nodes[i].transform.position);
            if (distance < shortesNude)
            {
                shortesNude = distance;
                nudes = i;
            }
        }
    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        Target = GameObject.Find("Tree").GetComponent<Transform>();
        objectStealed.gameObject.SetActive(false);
        sprRender = GetComponent<SpriteRenderer>();
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
            moveNode();
            EnemyRotation(Target.gameObject.transform.position);
        } else {
            objectStealed.gameObject.SetActive(true);
            transform.position = Vector2.MoveTowards(transform.position, exits[exit].transform.position, 5 * Time.deltaTime);
            EnemyRotation(exits[exit].transform.position);
        }

        //Rotacion hacia el objeto
        /*Vector2 direccion = Target.gameObject.transform.position - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);*/

        //Si llega al muro mas cercano despues de robar el regalo, muere
        if (Vector3.Distance(transform.position, exits[exit].transform.position) < 0.5f && stealed) Destroy(gameObject); 
    }

    private void EnemyRotation(Vector2 target) {

        //Gira el sprite dependiendo de la direccion
        Vector2 direction = target - new Vector2(transform.position.x, transform.position.y);
        if (direction.x < 0 && !sprRender.flipX) {
            sprRender.flipX = true;
        } else if (direction.x > 0 && sprRender.flipX) {
            sprRender.flipX = false;
        }

        //Si ha robado, cambia la posicion del regalo relativa al grinch para encajar en sus manos
        if (objectStealed.gameObject.activeSelf) {

            if (sprRender.flipX && objectStealed.transform.localPosition.x > 0) {
                objectStealed.transform.localPosition = new Vector3(-presentOffset.x, presentOffset.y, objectStealed.transform.localPosition.z);
            } else if(!sprRender.flipX && objectStealed.transform.localPosition.x < 0) {
                objectStealed.transform.localPosition = new Vector3(presentOffset.x, presentOffset.y, objectStealed.transform.localPosition.z);
            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Tree") {
            GameManager.regalos--;
            stealed = true;
        }
    }

    void moveNode()
    {

        switch (nudes)
        {
            case 0:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode1[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode1[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode1[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 1:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode2[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode2[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode2[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 2:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode3[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode3[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode3[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 3:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode4[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode4[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode4[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 4:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode5[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode5[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode5[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 5:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode6[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode6[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode6[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 6:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode7[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode7[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode7[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 7:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode8[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode8[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode8[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 8:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode9[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode9[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode9[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 9:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode10[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode10[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode10[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 10:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode11[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode11[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode11[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 11:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode12[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode12[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode12[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 12:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode13[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode13[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode13[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 13:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode14[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode14[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode14[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 14:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode15[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode15[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode15[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 15:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode16[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode16[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode16[way].transform.position) == 0)
                {
                    way++;
                }
                break;
            case 16:
                if (Vector2.Distance(transform.position, nodes[nudes].transform.position) >= 0)
                {
                    if (Vector2.Distance(transform.position, nodesFromNode17[way].transform.position) > 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, nodesFromNode17[way].transform.position, 3 * Time.deltaTime);
                    }
                }
                if (Vector2.Distance(transform.position, nodesFromNode17[way].transform.position) == 0)
                {
                    way++;
                }
                break;
        }
    }
}
