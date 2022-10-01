//Autor: Dulce María Silva Gutiérrez
//Fecha: 14 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controla el GameObject player y actuliza la posicion vertical y horizontal de un objeto
//y darle movimiento cuando las Axis vertical u Horizontalsean pulsadas.
public class PlayerController : MonoBehaviour
{
    //velocidad Vertical a la que se desplazara el objeto
    public float velocidad =20;
    //velocidad de rotación Horizontal a la que se moverá el objeto
    public float velGiro = 20;
    //Axis Vertical
    private float avanza; 
    //Axis Horizontales
    private float gira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Almacena 1 en caso de ser presionado un axis vertical, de no ser así devuelve 0
        avanza = Input.GetAxis("Vertical");
        //Almacena 1 en caso de ser presionado un axis horizontal, de no ser así devuelve 0
        gira= Input.GetAxis("Horizontal");
        //Genera el desplazamiento vertical del objeto en caso de que avanza sea 1
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        //Genera la rotacion en caso de que gira sea 1
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
