using UnityEngine;
using UnityEngine.InputSystem;

public class Animaciones : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float alturasalto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Saltar(InputAction.CallbackContext value)
    {

        if (value.started)
        {
            animator.SetBool("Saltar", true);
            rb.AddForce(Vector2.up * alturasalto);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Saltar", false);
        if(collision.transform.tag == "Enemigo")
        {
            GameManager.Instancia.Perder();
        }
    }
}