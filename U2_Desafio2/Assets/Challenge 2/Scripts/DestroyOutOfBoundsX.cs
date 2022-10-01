//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destruye los objetos dependiendo de su posición en pantalla
public class DestroyOutOfBoundsX : MonoBehaviour
{
    //Límite izuierdo para destruir un objeto
    private float leftLimit = -35;
    //Límite inferior para destruir un objeto
    private float bottomLimit = 0;

    // Update is called once per frame
    void Update()
    {
        // Destruye dogs si la posicion en "X" es menor al límite 
        if (transform.position.x < leftLimit)
        {
            //Destruye el objeto que se pasa por parámetro
            Destroy(gameObject);
        } 
        //Destruye balls si la posición en "Y" es menor al límite
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
