using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float axisX, axisY;
    private bool interact, shoot, pause;
    private Vector2 mousePos = Vector2.zero;

    public float speed = 10;
    private Vector2 movement = Vector2.zero;

    private Rigidbody2D rigid;
    private Animator anim;

    public static int ammo;

    public GameObject bulletPrefab;

    private SpriteRenderer sprRender;

    public GameObject pausePanel;

    
    // Use this for initialization
    void Start () {

        rigid = GetComponent<Rigidbody2D>();
        sprRender = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        pausePanel = GameObject.FindGameObjectWithTag("PausePanel");
        pausePanel.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        GetInputs();

        if (!GameManager.gamePaused) {

            PlayerRotation();

            movement = new Vector2(axisX, axisY);
            movement *= speed * Time.deltaTime;

            if(movement.magnitude > 0.0f) {
                anim.SetBool(anim.GetParameter(0).name, true);
            } else {
                anim.SetBool(anim.GetParameter(0).name, false);
            }

            rigid.MovePosition(rigid.position + movement);

            if (shoot)
            {
                
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<BulletMovement>().movement = new Vector3(mousePos.x - transform.position.x, mousePos.y - transform.position.y, 0).normalized;
            }

        }

        if (pause) {
            if(!GameManager.gamePaused) {
                pausePanel.GetComponentInParent<MainMenuScript>().PauseGame();
                pausePanel.SetActive(true);
            } else {
                pausePanel.GetComponentInParent<MainMenuScript>().ResumeGame();
                pausePanel.SetActive(false);
            }
        }

    }

    private void GetInputs() {
        
        axisX = Input.GetAxisRaw("Horizontal");
        axisY = Input.GetAxisRaw("Vertical");

        interact = Input.GetKeyDown(KeyCode.E);

        shoot = Input.GetMouseButtonDown(0);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        pause = Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P);

    }

    private void PlayerRotation() {

        Vector2 direction = mousePos - new Vector2(transform.position.x, transform.position.y);

        if (direction.x < 0 && !sprRender.flipX) {

            sprRender.flipX = true;

        } else if(direction.x > 0 && sprRender.flipX) {

            sprRender.flipX = false;

        }

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
