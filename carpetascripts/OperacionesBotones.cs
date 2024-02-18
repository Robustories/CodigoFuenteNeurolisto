using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperacionesBotones : MonoBehaviour
{
    public Estado estado;

    public void Guardar()
    {
        GestorDeEstado.Guardar(estado);
    }

    public void Cargar()
    {
        GestorDeEstado.Cargar(estado);
    }

}
