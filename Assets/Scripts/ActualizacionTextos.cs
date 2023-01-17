using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizacionTextos : MonoBehaviour
{
    [SerializeField] TMP_Text cronometro, actpuntos, MejPun;
    [SerializeField] GameManager gameManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cronometro.text = gameManager.segundos.ToString();
        actpuntos.text = gameManager.puntuacionActual.ToString();
        MejPun.text = gameManager.MejPunt.ToString();
    }
}
