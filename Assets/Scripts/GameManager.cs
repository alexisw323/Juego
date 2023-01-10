using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Texto;
    [SerializeField] GameObject Boton;
    [SerializeField] TMP_Text cronometro;
    [SerializeField] GameObject Jugador;
    [SerializeField] GameObject Enemigo;
    [SerializeField] bool activarCronometro;
    float tiempo, segundos;
    void Start()
    {
        Texto.SetActive(false);
        Boton.SetActive(false); 
        activarCronometro = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(activarCronometro == true)
        {
            tiempo += Time.deltaTime;
            segundos = (int)(tiempo);
            cronometro.text = segundos.ToString();
        }
    }
}
