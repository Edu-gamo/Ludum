using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float axisX, axisY;
    private bool interact, shoot;
    private Vector2 target = Vector2.zero;

    public float speed = 10;
    private Vector2 movement = Vector2.zero;

    private Rigidbody2D rigid;

    public static int ammo;

    public GameObject bulletPrefab;

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

        if (shoot) {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<BulletMovement>().movement = new Vector3(target.x - transform.position.x, target.y - transform.position.y, 0).normalized;
        }

    }

    void GetInputs() {
        
        axisX = Input.GetAxisRaw("Horizontal");
        axisY = Input.GetAxisRaw("Vertical");

        interact = Input.GetKeyDown(KeyCode.E);

        shoot = Input.GetMouseButtonDown(0);
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void OnTriggerStay2D(Collider2D collision) {
        
        if(collision.tag == "Elf") {

            if (interact) {
                
                ammo++;
                Destroy(collision.gameObject);

            }

        } else if (collision.tag == "ElfHouse") {

            if (interact && ammo > 0) {

                if(collision.GetComponent<ElfHouseManager>().AddElf()) ammo--;

            }

        }
        
    }

}
