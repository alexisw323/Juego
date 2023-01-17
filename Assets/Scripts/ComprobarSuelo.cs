using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour
{
    [SerializeField] public static bool estaEnSuelo;


    private void OnTriggerEnter2D(Collider2D other)
    {      
        if (other.transform.tag == "Suelo")
        {
            Debug.Log("Salta");
            estaEnSuelo = true;
        }           
    }

    private void OnTriggerExit2D(Collider2D other)
    {       
        if (other.transform.tag == "Suelo")
        {
            Debug.Log("Noooooooooo Salta");
            estaEnSuelo = false;
        }          
    }
}
