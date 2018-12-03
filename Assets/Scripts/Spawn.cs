using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject[] spawners; //Plataformas
    public GameObject[] enemy; //enemigo spawneado!!
    public GameObject[] elfs;
    public GameObject elf;
    public static int round;
    public int randSpawnPlatform;  //Spawn en una de las plataformas
    public int randSpawnPosition; //Posiciones random de spawn
    float counter; //contador
   public float timeSpawn; //tiempo de spawn de cada enemigo 

    float counterElf;
    float timeSpawnElf;
    public int randElfX;
    public int randElfY;

    public int timeForSpawn;
    public float timeDurationRound;
    public GameObject[] enemyS;

    public float timeRound;
    public bool endRound = false;
    public GameObject textRound;

    public GameObject rudolf;
    public GameObject spawnRudolf;
    // Update is called once per frame
    private void Start()
    {
        textRound.gameObject.SetActive(false);
        timeRound = 0;
        round = 0;
        Rudolf.presentToSteal = 10;
    }
    void Update()
    {
        if (round < 3)
        {
            Rudolf.presentToSteal = 10;
        }
        if (round < 6 && round > 3)
        {
            Rudolf.presentToSteal = 20;
        }
        if (round < 9 &&round > 6)
        {
            Rudolf.presentToSteal = 30;
        }
        //Debug.Log(round);
        //contador del juego 
        enemyS = GameObject.FindGameObjectsWithTag("Enemy");

        if(enemyS.Length == 0)
        {
            if (timeSpawn == 1000) //DURACION DESCANSO
            {
                if (round < 10)
                {
                    round++;
                }
               
                else if(round == 10)
                {
                    round = 10;
                }
               
                if (round == 3)
                {
                    Instantiate(rudolf, spawnRudolf.transform.position, Quaternion.identity);
                }
                if (round == 6)
                {
                    Instantiate(rudolf, spawnRudolf.transform.position, Quaternion.identity);
                }
                if (round == 9)
                {
                    Instantiate(rudolf, spawnRudolf.transform.position, Quaternion.identity);
                }
                timeSpawn = 0;
                timeDurationRound = 0;
            }
            else
            {
         
                timeSpawn++;
            }
        }
        else
        {
            timeSpawn = 0;
            timeDurationRound++;
        }
      
    
        //Elfos en la escena
        elfs = GameObject.FindGameObjectsWithTag("Elf");

        //Random entre las 4 plataformas que hay
        randSpawnPlatform = Random.Range(0, 4);
        //Random entre las posiciones de cada plataforma
        randSpawnPosition = Random.Range(-5, 5);

        oleadaSpawnEnemigos();
        spawnElfs();
    }
    void spawnElfs()
    {
        if (elfs.Length < 20) //numero elfos pantalla
        {
            if (counterElf > 150)
            {
                randElfX = Random.Range(-9, 9);
                randElfY = Random.Range(-5, 8);
                Instantiate(elf, new Vector2(randElfX, randElfY), Quaternion.identity);
                counterElf = 0;
            }
            else
            {
                counterElf++;
            }
        }
    }
    void oleadaSpawnEnemigos()
    {
        //OLEADA 1 -  //TIEMPO DURACION OLEADA 1
        switch (round) {
            case 0:
            if (timeDurationRound < 2000)
            {
                    if(timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                   if(timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
            //velocidad enemigos de esa oleada
            MovementEnemy.vel = 1f;
            //Tiempo de spawn de cada enemigo
            if (counter > 150)
            {
                //Si el random es de Derecha a izquierda
                if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                {
                    //Spawn random con Y random
                    Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                    spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                }
                //Si el random es de Arriba a abajo
                else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                {
                    //Spawn random con X random
                    Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                    spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                }
                counter = 0;
            }
            else
            {
                counter++;
            }
                }
                //OLEADA 2
                break;
            //TIEMPO DURACION OLEADA 2 
            case 1:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
            //Tiempo de spawn de cada enemigo
            if (counter > 145)
            {
                //Si el random es de Derecha a izquierda
                if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                {
                    //Spawn random con Y random
                    Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                    spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                }
                //Si el random es de Arriba a abajo
                else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                {
                    //Spawn random con X random
                    Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                    spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                }
                counter = 0;
            }
            else
            {
                counter++;

            }
                }
                break;
            case 2:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 135)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 3:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 130)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 4:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 125)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 5:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 120)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 6:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 105)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 7:
                if (timeDurationRound < 2000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 100)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 8:
                if (timeDurationRound < 2250)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 100)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 9:
                if (timeDurationRound < 2500)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 95)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
            case 10:
                if (timeDurationRound < 3000)
                {
                    if (timeDurationRound < 200)
                    {
                        textRound.gameObject.SetActive(true);
                    }
                    if (timeDurationRound > 200)
                    {
                        textRound.gameObject.SetActive(false);
                    }
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 95)
                    {
                        //Si el random es de Derecha a izquierda
                        if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
                        {
                            //Spawn random con Y random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x,
                            spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
                        }
                        //Si el random es de Arriba a abajo
                        else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
                        {
                            //Spawn random con X random
                            Instantiate(enemy[0], new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                            spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter++;

                    }
                }
                break;
        }
    }
}
