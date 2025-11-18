using Mono.Cecil;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int mejorPuntuacion;
    [SerializeField] public int puntuacionActual;
    [SerializeField] float tiempo;
    [SerializeField] GameObject guardarTexto;
    [SerializeField] GameObject boton;
    [SerializeField] GameObject guardarJugador;
    [SerializeField] GameObject GuardarEnemigo;
    [SerializeField] bool Activarcronometro;
    [SerializeField] DinoMalo Dino;
    private float tiempotranscurrido = 0f;


    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mejorPuntuacion = PlayerPrefs.GetInt("mejorPuntuacion");
        //guardarTexto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Activarcronometro)
        {
            tiempotranscurrido += Time.deltaTime;
        }
    }

    public void Perder()
    {
        gameObject.SetActive(false);
        //boton.SetActive(true);
        SceneManager.LoadScene("GAMEOVER");
    }
    public void ReiniciarJuego()
    {
      
        puntuacionActual = 0;
        gameObject.SetActive(true);
        boton.SetActive(false);
        Activarcronometro = true;
        Dino.IniciarEnemigo();
        
    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual++;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }
}
