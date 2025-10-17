using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GuiHelper : MonoBehaviour
{
 public void IniciarPartida()
 {
 GameManager.instance.ChangeScenes("07-Mecanica5-CambiarEscena-B");
 }
 public void VolverMenuPrincipal()
 {
 GameManager.instance.ChangeScenes("Portada");
 }
 public void CerrarAplicacion()
 {
 Application.Quit();
 }
}