using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unir4 : MonoBehaviour
{
    public GameObject A11, A12, A13, A14, B11, B12, B13, B14;
    Vector2 A11InitialPos, A12InitialPos, A13InitialPos, A14InitialPos;
    public GameObject pantallaContinuar1;
    public GameObject imagenCompleta1, imagenCompleta2, imagenCompleta3, imagenCompleta4;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A11correct, A12correct, A13correct, A14correct = false;
    // Start is called before the first frame update
    void Start()
    {
        A11InitialPos = A11.transform.position;
        A12InitialPos = A12.transform.position;
        A13InitialPos = A13.transform.position;
        A14InitialPos = A14.transform.position;

        pantallaContinuar1.gameObject.SetActive(false);
        imagenCompleta1.gameObject.SetActive(false);
        imagenCompleta2.gameObject.SetActive(false);
        imagenCompleta3.gameObject.SetActive(false);
        imagenCompleta4.gameObject.SetActive(false);
        
    }

    public void DragA1()
    {
        A11.transform.position = Input.mousePosition;
    }

    public void DragA2()
    {
        A12.transform.position = Input.mousePosition;
    }

    public void DragA3()
    {
        A13.transform.position = Input.mousePosition;
    }

    public void DragA4()
    {
        A14.transform.position = Input.mousePosition;
    }

    public void DropA1()
    {
        float Distance = Vector3.Distance(A11.transform.position, B11.transform.position);
        if (Distance < 50)
        {
            A11.transform.position = B11.transform.position;
            source.clip = correct;
            source.Play();
            A11correct = true;
            imagenCompleta1.gameObject.SetActive(true);
        }
        else
        {
            A11.transform.position = A11InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA2()
    {
        float Distance = Vector3.Distance(A12.transform.position, B12.transform.position);
        if (Distance < 50)
        {
            A12.transform.position = B12.transform.position;
            source.clip = correct;
            source.Play();
            A12correct = true;
            imagenCompleta2.gameObject.SetActive(true);
        }
        else
        {
            A12.transform.position = A12InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA3()
    {
        float Distance = Vector3.Distance(A13.transform.position, B13.transform.position);
        if (Distance < 50)
        {
            A13.transform.position = B13.transform.position;
            source.clip = correct;
            source.Play();
            A13correct = true;
            imagenCompleta3.gameObject.SetActive(true);
        }
        else
        {
            A13.transform.position = A13InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA4()
    {
        float Distance = Vector3.Distance(A14.transform.position, B14.transform.position);
        if (Distance < 50)
        {
            A14.transform.position = B14.transform.position;
            source.clip = correct;
            source.Play();
            A14correct = true;
            imagenCompleta4.gameObject.SetActive(true);
        }
        else
        {
            A14.transform.position = A14InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(A11correct && A12correct && A13correct && A14correct)
        {
            Debug.Log("You win");
            {Invoke ("U4", 0.6f);}
        }
        
    }

    void U4()
    { 
        pantallaContinuar1.SetActive(true);
    }
}
