using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaSeguroSalir : MonoBehaviour
{
    public GameObject este;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void SalirActividad(string nombre)
	{
		SceneManager.LoadScene(nombre);
	}

    public void QuitarPantalla()
    {
        este.SetActive(false);
    }
}
