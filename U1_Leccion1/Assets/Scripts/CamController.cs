//Autor: Dulce María Silva Gutiérrez
//Fecha: 14 - Septiembre - 2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controla el Objeto MainCamera y establece la posicion de la cámara en el juego 
//y actuliza dicha posición dependiendo de la posición de objeto de jugado
public class CamController : MonoBehaviour
{
    //referencia a Game object.
    public GameObject tanque;
    //Asigna una posición fija al objeto mainCamera
    public Vector3 upCam = new Vector3(0,10,-10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      ///Cambia la posicion del objeto mainCamera usando la posición de el objeto tanque.
      transform.position = tanque.transform.position + upCam;   
    }
}
