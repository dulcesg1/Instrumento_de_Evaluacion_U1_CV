//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detecta la colision entre dos objetos
public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //Dispara al detectar una colision 
    private void OnTriggerEnter(Collider other){//se envia como parámetro el Collider
        //Destruye el objeto
        Destroy(gameObject);
        //Destruiye el objeto con el cual se ha colisonado
        Destroy(other.gameObject);
    }
}
