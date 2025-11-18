using System.Collections;
using UnityEngine;

public class DinoMalo : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera cam;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] public GameObject dinoMalo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        posicionMinima = cam.ViewportToWorldPoint(Vector2.zero);
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
        }
    }
    public void IniciarEnemigo()
    {
        dinoMalo.transform.position = posicionInicial;
        velocidad = 15;
    }

}

