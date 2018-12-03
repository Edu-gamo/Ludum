using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Tutorial : MonoBehaviour {

    public GameObject tuto1;
    public GameObject tuto2;
    public GameObject tuto3;
    public GameObject tuto4;
    // Use this for initialization
    void Start () {
        tuto1.gameObject.SetActive(true);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GoSecond()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(true);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
    }
    public void backToFirst()
    {
        tuto1.gameObject.SetActive(true);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
    }
    public void goThird()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(true);
        tuto4.gameObject.SetActive(false);
    }
    public void BackSecond()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(true);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(false);
    }
    public void GoForth()
    {
        tuto1.gameObject.SetActive(false);
        tuto2.gameObject.SetActive(false);
        tuto3.gameObject.SetActive(false);
        tuto4.gameObject.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }
}
