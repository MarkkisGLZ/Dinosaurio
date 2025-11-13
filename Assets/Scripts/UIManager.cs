using TMPro;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActualTexto;
    [SerializeField] TMP_Text mejorPuntuacionTexto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puntuacionActualTexto.text = GameManager.Instancia.puntuacionActual.ToString();
        mejorPuntuacionTexto.text = GameManager.Instancia.mejorPuntuacion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActualTexto.text = GameManager.Instancia.puntuacionActual.ToString();
        mejorPuntuacionTexto.text = GameManager.Instancia.mejorPuntuacion.ToString();
    }
}
