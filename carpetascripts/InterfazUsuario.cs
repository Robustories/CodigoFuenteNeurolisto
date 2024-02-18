using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazUsuario : MonoBehaviour
{
    public GameObject menu;
    public bool menuMostrado;

    public void MostrarMenu()
    {
        menu.SetActive(true);
        menuMostrado = true;
    }

    public void EsconderMenu()
    {
        menu.SetActive(false);
        menuMostrado = false;
    }
   
}
