using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float velocidad, alturaSalto;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && ComprobarSuelo.estaEnSuelo)
        {
            rigidbody.AddForce(Vector2.up * alturaSalto);
            audioSource.Play();
        }

        if (rigidbody.velocity.y > 0.5f)
        {
            animator.SetBool("Saltar", true);
        }
        else if (rigidbody.velocity.y < -15)
        {
            animator.SetBool("Saltar", false);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemigo")
        {
            GameManager.Instancia.Perder();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Puntos")
        {
            GameManager.Instancia.ActualizarPuntos();
        }
    }
}
