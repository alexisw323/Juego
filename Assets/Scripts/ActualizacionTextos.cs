using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizacionTextos : MonoBehaviour
{
    [SerializeField] TMP_Text cronometro;
    [SerializeField] GameManager gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cronometro.text = gameManager.segundos.ToString();
    }
}
