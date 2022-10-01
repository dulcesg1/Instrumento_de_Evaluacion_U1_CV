//Autor: Dulce María Silva Gutiérrez
//Fecha: 14 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Actualiza la posicion de la cámara para seguir el GameObject player
public class FollowPlayerX : MonoBehaviour
{
    //Objeto al que seguirá la cámara 
    public GameObject plane;
    //Posicion inicial para la cámara
    private Vector3 offset= new Vector3(30,0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Actualiza la posición de la cámara en relación al GameObject  plane
        transform.position = plane.transform.position + offset;
    }
}
