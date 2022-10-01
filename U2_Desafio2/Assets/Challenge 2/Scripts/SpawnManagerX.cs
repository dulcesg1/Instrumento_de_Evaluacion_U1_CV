//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controla la creación aleatoria de un arreglo de objetos
public class SpawnManagerX : MonoBehaviour
{
    //Arreglo de objetos a crear
    public GameObject[] ballPrefabs;
    //Límite izquierdo de spawn
    private float spawnLimitXLeft = -22;
    //Límite derecho de spawn 
    private float spawnLimitXRight = 7;
    //Posición de spawn 
    private float spawnPosY = 30;
    //Deleay para inicio de funcion de spawn
    private float startDelay = 1.0f;
    //Tiempo de espera para repetición de spawn
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        //Crea un intervalo aleatorio de repetición entre 3 y 5 
        spawnInterval = Random.Range(3f,5f);
        //Repete la función enviada por parámetro de forma constante tomando encuentra el retraso de inicio y el intervalo de repetición
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
private void Update() {
   
}
    //Crea un objeto ball aleatorio del arreglo de objetos en una posición X aleatorio 
    void SpawnRandomBall ()
    {
        //Valor del objeto a crear de forma aleatoria considerando el tamaño del arreglo
        int ballIndex=Random.Range(0,ballPrefabs.Length);

        //Crea una posición aleatoria en que se crea el objeto ball
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instancia un objeto bola del arreglo de objetos en la posición aletorio spawnPos
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
