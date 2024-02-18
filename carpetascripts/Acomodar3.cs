using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acomodar3 : MonoBehaviour
{
    public GameObject A31, A32, A33, B31, B32, B33;
    Vector2 A31InitialPos, A32InitialPos, A33InitialPos;
    public GameObject pantallaContinuar3;
    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    bool A31correct, A32correct, A33correct  = false;

    void Start()
    {
        A31InitialPos = A31.transform.position;
        A32InitialPos = A32.transform.position;
        A33InitialPos = A33.transform.position;

        pantallaContinuar3.gameObject.SetActive(false);
        
    }

    public void DragA61()
    {
        A31.transform.position = Input.mousePosition;
    }

    public void DragA62()
    {
        A32.transform.position = Input.mousePosition;
    }

    public void DragA63()
    {
        A33.transform.position = Input.mousePosition;
    }

    public void DropA31()
    {
        float Distance = Vector3.Distance(A31.transform.position, B31.transform.position);
        if (Distance < 50)
        {
            A31.transform.position = B31.transform.position;
            source.clip = correct;
            source.Play();
            A31correct = true;
        }
        else
        {
            A31.transform.position = A31InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA62()
    {
        float Distance = Vector3.Distance(A32.transform.position, B32.transform.position);
        if (Distance < 50)
        {
            A32.transform.position = B32.transform.position;
            source.clip = correct;
            source.Play();
            A32correct = true;
        }
        else
        {
            A32.transform.position = A32InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA63()
    {
        float Distance = Vector3.Distance(A33.transform.position, B33.transform.position);
        if (Distance < 50)
        {
            A33.transform.position = B33.transform.position;
            source.clip = correct;
            source.Play();
            A33correct = true;
        }
        else
        {
            A33.transform.position = A33InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(A31correct && A32correct && A33correct)
        {
            Debug.Log("You win");
            {Invoke ("Continuar3", 0.8f); }
        }
        
    }

    void Continuar3()
    { 
        pantallaContinuar3.gameObject.SetActive(true); 
    }
}
