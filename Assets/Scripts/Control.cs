using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float velocidad, alturaSalto, alturaDobleSalto;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] bool confirmarDobleSalto;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        
        if(horizontal > 0)
        {
            rigidbody.velocity = new Vector2(velocidad,rigidbody.velocity.y);
            transform.localScale = new Vector2(4, 4);
            animator.SetBool("Correr", true);
        }
        else if( horizontal < 0)
        {
            rigidbody.velocity = new Vector2(-velocidad, rigidbody.velocity.y);
            transform.localScale = new Vector2(-4, 4);
            animator.SetBool("Correr", true);
        }
        else
        {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
            animator.SetBool("Correr", false);
        }

        if(Input.GetButtonDown("Jump") && ComprobarSuelo.estaEnSuelo)
        {
            rigidbody.AddForce(Vector2.up* alturaSalto);
            confirmarDobleSalto = true;
        }
        else if(Input.GetButtonDown("Jump") && !ComprobarSuelo.estaEnSuelo && confirmarDobleSalto)
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * alturaDobleSalto);
            confirmarDobleSalto = false;
        }

        if(rigidbody.velocity.y >0.5f)
        {
            animator.SetBool("Saltar", true);
        }
        else if(rigidbody.velocity.y < -0.5f)
        {
            animator.SetBool("Saltar", false);

        }
    }
}
