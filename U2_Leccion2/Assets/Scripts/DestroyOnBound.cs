//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destruye un objeto
public class DestroyOnBound : MonoBehaviour
{
    //Referencia  de posición superior para destruir objeto
    public float topBound=30;
    //Referencia de posición inferior para destruir objeto
    public float lowerBound=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Valida si la posición del objeto en "Z" es mayor a la posición superior 
        if(transform.position.z>topBound){
            Destroy(gameObject);//se destruye el objeto
            
        }else if(transform.position.z<lowerBound){//Valida si la posicion del objeto en z es menor a la posicion inferior 
            //Se envia mensaje a log 
            Debug.Log("Game Over!");
            //Funcion que destruye el objeto enviado por parametro
            Destroy(gameObject);
        }
    }
}
