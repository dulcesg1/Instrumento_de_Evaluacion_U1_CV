//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controla los movimientos del proyectil Bone y animales
public class Bone : MonoBehaviour
{
    //Velocidad a la que se desplaza el objeto
    public float velocidad=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //Transforma la posicion del objeto de forma constante por la velocidad establecida
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad);
        
    }
}
