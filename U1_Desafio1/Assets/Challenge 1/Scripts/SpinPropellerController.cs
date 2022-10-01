//Autor: Dulce María Silva Gutiérrez
//Fecha: 14 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Clase genera la rotación en el rotor del GameObject
public class SpinPropellerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
    }

       // Update is called once per frame
    void Update()
    {
        //Rota el objeto con la función Euler generando la animación del rotor
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
       
    }
}
