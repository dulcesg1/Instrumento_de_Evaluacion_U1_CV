//Autor: Dulce María Silva Gutiérrez
//Fecha: 29 - Septiembre - 2022
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Clase que controla el objeto jugador
public class PlayerControllerX : MonoBehaviour
{
    //Objeto que se genera
    public GameObject dogPrefab;
    //Flag por sise puede generar un nuevo objeto dog
    private bool bBanderaPerro = true;
    private void Start()
    {

    }

    private void Update()
    {
        //Detiene la actualización durante el tiempo 
        StartCoroutine(SpawnDog());
    }
    //gGenera un nuevo objeto perro
    private IEnumerator SpawnDog()
    {
    
        // Válida si se presiona la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Valida si el perro ha sido generado
            if (bBanderaPerro)
            {
                //La flag toma un valor falso para no generar un nuevo perro hasta que termine la espera
                bBanderaPerro = false;
                //Crea una instancia del objeto enviado por parámetro con la posición y rotación
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                //se detiene 2 segundos antes de continar
                yield return new WaitForSeconds(2f);
                //Se cambia la flag a verdadero para poder crear un nuevo perro
                bBanderaPerro = true;
            }
        }
    }
}
