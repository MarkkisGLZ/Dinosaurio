using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InicioJuego : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    public void Jugar()
    {
        StartCoroutine(EsperarSonido());
    }
    public void CerrarJuego(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Application.Quit();
        }
    }
    IEnumerator EsperarSonido()
    {
        audioSource.Play();
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("Juego");
    }
}