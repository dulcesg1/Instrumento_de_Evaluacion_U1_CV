//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Da movimiento a un objeto
public class MoveForwardX : MonoBehaviour
{
    //Velocidad a la que se mueve el objeto
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Cambia la posición del objeto constantemente en relación a la velocidad 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
