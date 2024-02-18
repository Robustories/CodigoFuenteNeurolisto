using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Patron : MonoBehaviour
{ 
    
    public List<int> patronNumeros;
    public int positionInSequence;
    public int inputInSequence;
    public GameObject actividadLograda;
    private bool correcto;
    public static bool incorrecto = false;
    //private bool gameActive;
    private bool patronEnMarcha;
    public int objetivoNivel2;
    public GameObject secuencia;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;

    public GameObject Completable;
    public GameObject[] figuraPrefeab;
    public GameObject Indicaciones;
    public Reloj reloj;




    int numeroActual;
    int indice;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        actividadLograda.gameObject.SetActive(false);
        //boton1.gameObject.SetActive(false);
        //boton2.gameObject.SetActive(false);
        //boton3.gameObject.SetActive(false);
        //boton4.gameObject.SetActive(false);
        //Completable.gameObject.SetActive(false);
        figuraPrefeab[0].gameObject.SetActive(false);
        figuraPrefeab[1].gameObject.SetActive(false);
        figuraPrefeab[2].gameObject.SetActive(false);
        figuraPrefeab[3].gameObject.SetActive(false);
        figuraPrefeab[4].gameObject.SetActive(false);
        figuraPrefeab[5].gameObject.SetActive(false);
        figuraPrefeab[6].gameObject.SetActive(false);
        figuraPrefeab[7].gameObject.SetActive(false);
        figuraPrefeab[8].gameObject.SetActive(false);
        figuraPrefeab[9].gameObject.SetActive(false);
        
        
        //Invoke("Ocultarsecuencia", 15);
        //Invoke("Mostrarbotones", 0,1);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(correcto == true)
        {
            numeroActual = patronNumeros[inputInSequence];
            
            

            //gameActive = false;
        }

        if(incorrecto == true)
        {
            //Reiniciar();
            //gameActive = false;
            

        }

        if(patronEnMarcha)
        {
            Debug.Log("debeseroscuro esta activo");
            

            if (positionInSequence >= patronNumeros.Count)
            {
                patronEnMarcha = false;
                //gameActive = true;
                Debug.Log("gameActive esta activo");
            }
        }

        if(inputInSequence == objetivoNivel2)
        {
            Invoke ("GanarPatron", 0.6f); 
        } 

        
    }

    public void RevisarCuadrado()
    {
        //if(gameActive){
        if(patronNumeros[inputInSequence] == 1){correcto = true;
        figuraPrefeab[inputInSequence].SetActive(true);
        inputInSequence++;
        Debug.Log("Cuadrado correcto");
        Debug.Log(inputInSequence);}
        else{inputInSequence = 0;
        secuencia.gameObject.SetActive(true);
        //Invoke("Ocultarsecuencia", 0.1f);
        //Invoke("Mostrarbotones", ,1);
        Ocultarbotones();
        }

        //}

    }

    public void RevisarCirculo()
    {
        //if(gameActive){
        if(patronNumeros[inputInSequence]  == 2){correcto = true;
        figuraPrefeab[inputInSequence].SetActive(true);
        inputInSequence++;
        Debug.Log("Circulo correcto");
        Debug.Log(inputInSequence);}
        else{inputInSequence = 0;
        secuencia.gameObject.SetActive(true);
        //Invoke("Ocultarsecuencia", 0.1f);
        //Invoke("Mostrarbotones", ,1);
        Ocultarbotones();
        }
        

    }

    public void RevisarTriangulo()
    {
        //if(gameActive){
        if(patronNumeros[inputInSequence]  == 3)
        {figuraPrefeab[inputInSequence].SetActive(true);
        inputInSequence++;
        Debug.Log("Triangulo correcto");
        Debug.Log(inputInSequence);}
        else{inputInSequence = 0;
        secuencia.gameObject.SetActive(true);
        //Invoke("Ocultarsecuencia", 0.1f);
        //Invoke("Mostrarbotones", ,1);
        Ocultarbotones();
        }

    }

    public void RevisarRectangulo()
    {
        //if(gameActive){
        if(patronNumeros[inputInSequence]  == 4)
        {figuraPrefeab[inputInSequence].SetActive(true);
        inputInSequence++;
        Debug.Log("Rectangulo correcto");}
        else{inputInSequence = 0;
        secuencia.gameObject.SetActive(true);
        //Invoke("Ocultarsecuencia", 0.1f);
        //Invoke("Mostrarbotones", ,1);
        Ocultarbotones();
        }

    }

    public void Reiniciar(string nombre)
    {
        SceneManager.LoadScene(nombre);

    }

    void Ocultarsecuencia()
    {
        secuencia.gameObject.SetActive(false);
        
    }

    void Mostrarsecuencia()
    {
        secuencia.gameObject.SetActive(true);
        
    }

    void Mostrarbotones()
    {
        boton1.gameObject.SetActive(true);
        boton2.gameObject.SetActive(true);
        boton3.gameObject.SetActive(true);
        boton4.gameObject.SetActive(true);
        Completable.gameObject.SetActive(true);
        //Indicaciones.gameObject.SetActive(true);
        incorrecto = false;
    }

    void Ocultarbotones()
    {
        //boton1.gameObject.SetActive(false);
        //boton2.gameObject.SetActive(false);
        //boton3.gameObject.SetActive(false);
        //boton4.gameObject.SetActive(false);
        //Completable.gameObject.SetActive(false);
        figuraPrefeab[0].gameObject.SetActive(false);
        figuraPrefeab[1].gameObject.SetActive(false);
        figuraPrefeab[2].gameObject.SetActive(false);
        figuraPrefeab[3].gameObject.SetActive(false);
        figuraPrefeab[4].gameObject.SetActive(false);
        figuraPrefeab[5].gameObject.SetActive(false);
        figuraPrefeab[6].gameObject.SetActive(false);
        figuraPrefeab[7].gameObject.SetActive(false);
        figuraPrefeab[8].gameObject.SetActive(false);
        figuraPrefeab[9].gameObject.SetActive(false);
        //Indicaciones.gameObject.SetActive(false);
        //Invoke("Ocultarsecuencia", 15);
        //Invoke("Mostrarbotones", 15);
        incorrecto = true;
        //reloj.Reiniciar();
        
    }

    void GanarPatron()
    { 
        actividadLograda.SetActive(true);
    }

}
