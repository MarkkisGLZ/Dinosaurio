using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Vector2 offset;
    [SerializeField] Vector2 velocidad;
    [SerializeField] Vector2 posicionAnteriorCamara;
    [SerializeField] Material material;
    [SerializeField] Camera camara;

    void Start()
    {
        camara = Camera.main;
        posicionAnteriorCamara = camara.transform.position;
        material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        offset = velocidad * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
