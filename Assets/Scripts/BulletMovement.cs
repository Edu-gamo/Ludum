using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public Vector3 movement;
    public float speed = 15;

    public ParticleSystem explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += movement * speed * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.tag == "Enemy") {
            MovementEnemy.explodeSound.Play();
            collision.GetComponent<MovementEnemy>().hp--;
        }

        if (collision.tag != "Player" && collision.tag != "Elf") {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
