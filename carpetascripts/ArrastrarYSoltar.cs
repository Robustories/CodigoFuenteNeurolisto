using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastrarYSoltar : MonoBehaviour
{
    public GameObject A1, A2, A3, A4, A5, A6, B1, B2, B3, B4, B5, B6;

    Vector2 A1InitialPos, A2InitialPos, A3InitialPos, A4InitialPos, A5InitialPos, A6InitialPos;
    public GameObject pantallaContinuar;
    public GameObject juegoTerminado;
    public GameObject timer;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    private int puntosAcumuladosa;
    public int puntosGanar;

    bool A1correct, A2correct, A3correct, A4correct, A5correct, A6correct = false;
    private int puntosNegativos;

    void Start()
    {
        A1InitialPos = A1.transform.position;
        A2InitialPos = A2.transform.position;
        A3InitialPos = A3.transform.position;
        A4InitialPos = A4.transform.position;
        A5InitialPos = A5.transform.position;
        A6InitialPos = A6.transform.position;
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

    public void DragA5()
    {
        A5.transform.position = Input.mousePosition;
    }

    public void DragA6()
    {
        A6.transform.position = Input.mousePosition;
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
            puntosAcumuladosa++;
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
            puntosAcumuladosa++;
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
            puntosAcumuladosa++;
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
            puntosAcumuladosa++;
        }
        else
        {
            A4.transform.position = A4InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

    public void DropA5()
    {
        float Distance = Vector3.Distance(A5.transform.position, B5.transform.position);
        if (Distance < 50)
        {
            A5.transform.position = B5.transform.position;
            source.clip = correct;
            source.Play();
            A5correct = true;
            puntosAcumuladosa++;
        }
        else
        {
            A5.transform.position = A5InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

    public void DropA6()
    {
        float Distance = Vector3.Distance(A6.transform.position, B6.transform.position);
        if (Distance < 50)
        {
            A6.transform.position = B6.transform.position;
            source.clip = correct;
            source.Play();
            A6correct = true;
            puntosAcumuladosa++;
        }
        else
        {
            A6.transform.position = A6InitialPos;
            source.clip = incorrect;
            source.Play();
            puntosNegativos++;
        }
    }

    void Update()
    {
        if(A1correct && A2correct && A3correct && A4correct && A5correct && A6correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarA", 1.0f); }
            {timer.gameObject.SetActive(false); }   
        }

        if(puntosNegativos == 7)
        {
            {juegoTerminado.gameObject.SetActive(true); }
            {A1.gameObject.SetActive(false); }
            {A2.gameObject.SetActive(false); }
            {A3.gameObject.SetActive(false); }
            {A4.gameObject.SetActive(false); }
            {A5.gameObject.SetActive(false); }
            {A6.gameObject.SetActive(false); }
            {timer.gameObject.SetActive(false);}    
        }

    }

    void ContinuarA()
    { 
        pantallaContinuar.gameObject.SetActive(true); 
    }



}
