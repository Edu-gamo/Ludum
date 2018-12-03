﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject[] spawners; //Plataformas
    public GameObject[] enemy; //enemigo spawneado!!
    public GameObject[] elfs;
    public GameObject elf;
    int round = 0;
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

    public float timeRound = 0;
    public bool endRound = false;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(round);
        //contador del juego 
        enemyS = GameObject.FindGameObjectsWithTag("Enemy");

        if(enemyS.Length == 0)
        {
            if (timeSpawn == 500) //DURACION DESCANSO
            {
                round++;
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
        if (elfs.Length < 5)
        {
            if (counterElf > 500)
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
            if (timeDurationRound < 500)
            {
            //velocidad enemigos de esa oleada
            MovementEnemy.vel = 1f;
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
                //OLEADA 2
                break;
            //TIEMPO DURACION OLEADA 2 
            case 1:
                if (timeDurationRound < 500)
        {
            MovementEnemy.vel = 2f;
            //Tiempo de spawn de cada enemigo
            if (counter > 50)
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
                if (timeDurationRound < 700)
                {
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 50)
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
                if (timeDurationRound < 700)
                {
                    MovementEnemy.vel = 2f;
                    //Tiempo de spawn de cada enemigo
                    if (counter > 50)
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
