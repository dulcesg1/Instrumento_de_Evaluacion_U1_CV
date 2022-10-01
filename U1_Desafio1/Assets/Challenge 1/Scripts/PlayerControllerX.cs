//Autor: Dulce María Silva Gutiérrez
//Fecha: 14 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Genera el movieminto en el GameObject de player.
public class PlayerControllerX : MonoBehaviour
{
    //velocidad Vertical a la que avanzará el GameObject
    public float speed;
     //velocidad Horizontal a la que rotará el GameObject
    public float rotationSpeed;
    //valor del axis Vertical
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtiene la entrada vertical del usuario 
        verticalInput = Input.GetAxis("Vertical");

        // Mueve el game object de forma constante 
        transform.Translate(Vector3.forward * Time.deltaTime* speed);

        //Eleva o inclina el GameObject en relacion a la entrada vertical del usuario
        transform.Rotate(Vector3.left *rotationSpeed*Time.deltaTime*verticalInput);
    }
}
