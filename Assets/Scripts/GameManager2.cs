using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    [SerializeField] GameObject guardarTexto;
    [SerializeField] GameObject boton;
    [SerializeField] GameObject guardarJugador;
    [SerializeField] GameObject GuardarEnemigo;
    [SerializeField] bool Activarcronometro;
    [SerializeField] DinoMalo Dino;
    private float tiempotranscurrido = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        guardarTexto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Activarcronometro)
        {
            tiempotranscurrido += Time.deltaTime;
        }
    }
}
