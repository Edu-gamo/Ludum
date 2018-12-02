using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject[] spawners; //Plataformas
    public GameObject[] enemy; //enemigo spawneado!!
    public GameObject[] elfs;
    public GameObject elf;

    public int randSpawnPlatform;  //Spawn en una de las plataformas
    public int randSpawnPosition; //Posiciones random de spawn
    float counter; //contador
    float timeSpawn; //tiempo de spawn de cada enemigo 

    float counterElf;
    float timeSpawnElf;
    public int randElfX;
    public int randElfY;

    public int timeForSpawn;
    // Update is called once per frame
    void Update()
    {
        //contador del juego 
        timeForSpawn++;
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
        if (timeForSpawn < 2000 && timeForSpawn > 0)
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
        //TIEMPO DURACION OLEADA 2 - EL DESCANSO QUE HAY ENTRE OLEADA
        if (timeForSpawn < 6000 && timeForSpawn > 4000)
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
        //TIEMPO DURACION OLEADA 3 - EL DESCANSO QUE HAY ENTRE OLEADA
        if (timeForSpawn < 8000 && timeForSpawn > 6000)
        {
            MovementEnemy.vel = 3f;
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
        //TIEMPO DURACION OLEADA 4 - 10000-8000
        if (timeForSpawn < 10000 && timeForSpawn > 8000)
        {
            MovementEnemy.vel = 4f;
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
        if (timeForSpawn < 14000 && timeForSpawn > 11000)
        {
            MovementEnemy.vel = 6f;
            //Tiempo de spawn de cada enemigo
            if (counter > 200)
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
        //maximo elfos permitidos             

    }
}
