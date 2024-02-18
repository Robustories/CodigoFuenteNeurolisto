using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescubreLaPalabra : MonoBehaviour
{
    public GameObject A1, A2, A3, A4,  B1, B2, B3, B4;

    Vector2 A1InitialPos, A2InitialPos, A3InitialPos, A4InitialPos;
    public GameObject pantallaContinuar;
    public GameObject juegoTerminado;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A1correct, A2correct, A3correct, A4correct = false;
    private int puntosNegativos;

    void Start()
    {
        A1InitialPos = A1.transform.position;
        A2InitialPos = A2.transform.position;
        A3InitialPos = A3.transform.position;
        A4InitialPos = A4.transform.position;
        
        pantallaContinuar.gameObject.SetActive(false);
        juegoTerminado.gameObject.SetActive(false);

    }

    public void DragA1()
    {
        A1.transform.position = Input.mousePosition;
    }

    public void DragA2()
    {
        A2.transform.position = Input.mousePosition;
    }

    public void DragA3()
    {
        A3.transform.position = Input.mousePosition;
    }

    public void DragA4()
    {
        A4.transform.position = Input.mousePosition;
    }

    

    public void DropA1()
    {
        float Distance = Vector3.Distance(A1.transform.position, B1.transform.position);
        if (Distance < 50)
        {
            A1.transform.position = B1.transform.position;
            source.clip = correct;
            source.Play();
            A1correct = true;
        }
        else
        {
            A1.transform.position = A1InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

    public void DropA2()
    {
        float Distance = Vector3.Distance(A2.transform.position, B2.transform.position);
        if (Distance < 50)
        {
            A2.transform.position = B2.transform.position;
            source.clip = correct;
            source.Play();
            A2correct = true;
        }
        else
        {
            A2.transform.position = A2InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

    public void DropA3()
    {
        float Distance = Vector3.Distance(A3.transform.position, B3.transform.position);
        if (Distance < 50)
        {
            A3.transform.position = B3.transform.position;
            source.clip = correct;
            source.Play();
            A3correct = true;
        }
        else
        {
            A3.transform.position = A3InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

    public void DropA4()
    {
        float Distance = Vector4.Distance(A4.transform.position, B4.transform.position);
        if (Distance < 50)
        {
            A4.transform.position = B4.transform.position;
            source.clip = correct;
            source.Play();
            A4correct = true;
        }
        else
        {
            A4.transform.position = A4InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

   

    void Update()
    {
        if(A1correct && A2correct && A3correct && A4correct)
        {
            Debug.Log("You win");
            {Invoke ("Pasa", 0.5f); }
            
        }

        if(puntosNegativos == 3)
        {
            {Invoke ("NoPasa", 0.5f); }
            {A1.gameObject.SetActive(false); }
            {A2.gameObject.SetActive(false); }
            {A3.gameObject.SetActive(false); }
            {A4.gameObject.SetActive(false); }
        }

    }

    void Pasa()
    { 
        pantallaContinuar.SetActive(true);
    }

    void NoPasa()
    { 
        juegoTerminado.SetActive(true);
    }



}
