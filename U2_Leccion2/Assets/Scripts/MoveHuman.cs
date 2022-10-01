//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controla los movimientos del jugador
public class MoveHuman : MonoBehaviour
{
    //Velocidad de movimiento deljugador
    public float velocidad=5.0F;
    //Maxima posicion del jugador 
    public float maximo=20;
    //Objeto proyectil que a generar
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //Valida si la posicion del objeto jugador es mayor que el maximo 
        if(transform.position.x>maximo){
            //Mantiene el objeto a la poscion maximo
            transform.position=new Vector3(maximo,transform.position.y,transform.position.z);
        }
        //Valida si la posicion del objeto es menor a -maximo se 
        if(transform.position.x<-maximo){
            //Mantiene el objeto a la posicion -maximo
            transform.position=new Vector3(-maximo,transform.position.y,transform.position.z);
        }
        //Trae la entrada de los axis horizontales izquierda derecha
        float flechas=Input.GetAxis("Horizontal");

        //Cambia la posicion del jugador a un axis horizontal
        transform.Translate(Vector3.right*Time.deltaTime*velocidad*flechas);

        //Valida si se presiona el espacio 
        if(Input.GetKeyDown(KeyCode.Space)){
            
            //Lanza proyectil del jugador instanciado el objeto Bone
          Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }

    }
}
