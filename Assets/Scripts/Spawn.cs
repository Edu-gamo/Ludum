using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject[] spawners; //Plataformas
    public GameObject enemy; //enemigo spawneado!!
   
    public int randSpawnPlatform;  //Spawn en una de las plataformas
    public int randSpawnPosition; //Posiciones random de spawn
    float counter; //contador
    float timeSpawn; //tiempo de spawn de cada enemigo 
    // Update is called once per frame
    void Update()
    {
        //Random entre las 4 plataformas que hay
        randSpawnPlatform = Random.Range(0, 4);
        //Random entre las posiciones de cada plataforma
        randSpawnPosition = Random.Range(-5, 5);

        //Oleada 1 
        //Tiempo de spawn de cada enemigo
        if (counter > 100)
        {
            //Si el random es de Derecha a izquierda
            if (randSpawnPlatform == 0 || randSpawnPlatform == 1)
            {
                //Spawn random con Y random
                Instantiate(enemy, new Vector2(spawners[randSpawnPlatform].transform.position.x,
                spawners[randSpawnPlatform].transform.position.y + randSpawnPosition), Quaternion.identity);
            }
            //Si el random es de Arriba a abajo
            else if (randSpawnPlatform == 2 || randSpawnPlatform == 3)
            { 
                //Spawn random con X random
                Instantiate(enemy, new Vector2(spawners[randSpawnPlatform].transform.position.x + randSpawnPosition,
                spawners[randSpawnPlatform].transform.position.y), Quaternion.identity);
            }
            counter = 0;
        }
        else
        {
            counter++;
        }


    }
}
