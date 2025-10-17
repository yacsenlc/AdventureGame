// Universidad Estatal a Distancia
// Introducción a Unity
// Autor: Lic. Juan Pablo Navarro Fennell

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDoor : MonoBehaviour
{
    // Miembros de clase pública
    public GameObject puerta;
    public Color colorRequerido;
    public float distanciaMover = 3f;

    // Miembros de clase protegidos
    protected Renderer puertaRender;
    protected bool abierto;

    // Método que se ejecuta cuando aparece este objeto en pantalla
    void Start()
    {
        puertaRender = puerta.GetComponent<Renderer>();
        puertaRender.material.color = colorRequerido;
    }

    private void OnTriggerEnter(Collider other)
{
    if (!abierto && other.CompareTag("Player"))
    {
        PlayerData playerdata = other.gameObject.GetComponent<PlayerData>();

        if (playerdata != null && playerdata.colorActual == colorRequerido)
        {
            puerta.transform.Translate(Vector3.down * distanciaMover);
            abierto = true;
        }
        else if (playerdata == null)
        {
            Debug.LogWarning("El objeto Player no tiene el componente PlayerData.");
        }
    }
}
}   
