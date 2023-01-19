using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] GameObject Texto;
    [SerializeField] GameObject Boton;
    [SerializeField] GameObject Jugador;
    [SerializeField] GameObject Enemigo;
    [SerializeField] bool activarCronometro;
    [SerializeField] public int puntuacionActual, MejPunt;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] sonidos;
    public float tiempoGM, segundos;
    public void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this; DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        MejPunt = PlayerPrefs.GetInt("MejPunt");
    }
    void Start()
    {
        Texto.SetActive(false);
        Boton.SetActive(false);
        activarCronometro = true;
        audioSource.clip = sonidos[0];
        audioSource.Play();
        audioSource.loop = true;
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
        audioSource.clip = sonidos[1];
        audioSource.Play();
        audioSource.loop = false;
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
        Enemigo.GetComponent<Enemigo>().IniciarEnemigo();
        audioSource.clip = sonidos[0];
        audioSource.Play();
        audioSource.loop = true;
    }
    public void ActualizarPuntos()
    {
        puntuacionActual++;
        if (puntuacionActual > MejPunt)
        {
            MejPunt = puntuacionActual;
            PlayerPrefs.SetInt("MejPunt", MejPunt);
        }
    }
}
