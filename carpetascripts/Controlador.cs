using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controlador : MonoBehaviour {

	public GameObject menu;
    public bool menuMostrado;
	
    
	
    

    void Start()
    {
        
    }


	public void CambiarEscena(string nombre)
	{
		SceneManager.LoadScene(nombre);
	}

	public void Salir()
	{
		print ("Saliendo del juego");
		Application.Quit();
	}

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

	

    

    
        

    

    void Update()
    {
        
    }

    

    


}
