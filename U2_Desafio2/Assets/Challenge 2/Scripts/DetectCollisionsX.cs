//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destruiye los objetos al detectar una collision
public class DetectCollisionsX : MonoBehaviour
{
//Dispara  al detectar una colision
//Envia como parámetro el collider
    private void OnTriggerEnter(Collider other)
    {
        //Destruye el objeto que se envio por parámetro
        Destroy(gameObject);
    }
}
