using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Texto;
    [SerializeField] GameObject Boton;
    [SerializeField] GameObject Jugador;
    [SerializeField] GameObject Enemigo;
    [SerializeField] bool activarCronometro;
    [SerializeField] int puntuacionActual;
    public float tiempoGM, segundos;
    void Start()
    {
        Texto.SetActive(false);
        Boton.SetActive(false);
        activarCronometro = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (activarCronometro == true)
        {
            tiempoGM += Time.deltaTime;
            segundos = (int)(tiempoGM);
        }
    }
    public void Perder()
    {
        Jugador.SetActive(false);
        Enemigo.SetActive(false);
        Texto.SetActive(true);
        Boton.SetActive(true);
        activarCronometro = false;
    }
    public void Reiniciar()
    {
        puntuacionActual = 0;
        Jugador.SetActive(true);
        Enemigo.SetActive(true);
        Texto.SetActive(false);
        Boton.SetActive(false);
        tiempoGM = 0;
        activarCronometro = true;
        //IniciarEnemigo();
    }
}
