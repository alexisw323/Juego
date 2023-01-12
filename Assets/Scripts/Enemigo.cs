using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector3 posicionInicial, posicionMinima;
    [SerializeField] float velocidad, velocidadInicial;
    void Start()
    {
        velocidadInicial = velocidad;
        posicionInicial = gameObject.transform.position;
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > posicionMinima.x)
        {
            transform.Translate(Vector2.left * Time.deltaTime * velocidad);
        }
        else
        {
            gameObject.transform.position = posicionInicial;
            velocidad++;
        }
    }
    public void IniciarEnemigo()
    {
        gameObject.transform.position = posicionInicial;
        velocidad = velocidadInicial;
    }
}
