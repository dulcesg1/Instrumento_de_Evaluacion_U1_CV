//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generaa objetos animal de manera aleatoria
public class SpawnManager : MonoBehaviour
{
    //Arreglo de objetos a generar
    public GameObject[] animalPrefabs;

    //Rango en X maximo para generar obejto
    private float spawnRangeX=20;
    
    //Rango en X maximo para generar obejto
    private float spawnPosZ=20;
    
    //Retraso de inicio de funcion InvokeRepeating
    private float startDelay=2;
    
    //Retraso de repeticion de funcion InvokeRepeating
    private float spawnInterval=1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Repite la funcion enviada por parametro en un intervalo indicado
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    //Funcion para generar animales
    void SpawnRandomAnimal(){
        //Indice aleatorio del animal a generar de acuerdo el tamaño del arreglo de objetos
        int animalIndex=Random.Range(0,animalPrefabs.Length);

        //Posicion aleatoria para crearobjetos de animales
        Vector3 spawnPos= new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

        //Crea animales tomando el indice aleatorio generado y la posicion aleatorio generada
        Instantiate(animalPrefabs[animalIndex],spawnPos,
        animalPrefabs[animalIndex].transform.rotation);

    }
}
