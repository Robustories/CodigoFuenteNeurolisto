using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rompecabezas : MonoBehaviour
{
    public GameObject R1, R2, R3, R4, R5, R6, R7, BR1, BR2, BR3, BR4, BR5, BR6, BR7;

    Vector2 R1InitialPos, R2InitialPos, R3InitialPos, R4InitialPos, R5InitialPos, R6InitialPos, R7InitialPos;

    public GameObject pantallaContinuaraR;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    public GameObject ImagenFormada;

    bool R1correct, R2correct, R3correct, R4correct, R5correct, R6correct, R7correct;
    // Start is called before the first frame update
    void Start()
    {
        R1InitialPos = R1.transform.position;
        R2InitialPos = R2.transform.position;
        R3InitialPos = R3.transform.position;
        R4InitialPos = R4.transform.position;
        R5InitialPos = R5.transform.position;
        R6InitialPos = R6.transform.position;
        R7InitialPos = R7.transform.position;

        pantallaContinuaraR.SetActive(false);
        ImagenFormada.SetActive(false);
        
    }

    public void DragR1()
    {
        R1.transform.position = Input.mousePosition;
        
    }

    public void DragR2()
    {
        R2.transform.position = Input.mousePosition;
    }

    public void DragR3()
    {
        R3.transform.position = Input.mousePosition;
    }

    public void DragR4()
    {
        R4.transform.position = Input.mousePosition;
    }

    public void DragR5()
    {
        R5.transform.position = Input.mousePosition;
    }

    public void DragR6()
    {
        R6.transform.position = Input.mousePosition;
    }

    public void DragR7()
    {
        R7.transform.position = Input.mousePosition;
    }

    public void DropR1()
    {
        float Distance = Vector3.Distance(R1.transform.position, BR1.transform.position);
        if (Distance < 50)
        {
            R1.transform.position = BR1.transform.position;
            source.clip = correct;
            source.Play();
            R1correct = true;
   
        }
        else
        {
            R1.transform.position = R1InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropR2()
    {
        float Distance = Vector3.Distance(R2.transform.position, BR2.transform.position);
        if (Distance < 50)
        {
            R2.transform.position = BR2.transform.position;
            source.clip = correct;
            source.Play();
            R2correct = true;
   
        }
        else
        {
            R2.transform.position = R2InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropR3()
    {
        float Distance = Vector3.Distance(R3.transform.position, BR3.transform.position);
        if (Distance < 50)
        {
            R3.transform.position = BR3.transform.position;
            source.clip = correct;
            source.Play();
            R3correct = true;
   
        }
        else
        {
            R3.transform.position = R3InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropR4()
    {
        float Distance = Vector3.Distance(R4.transform.position, BR4.transform.position);
        if (Distance < 50)
        {
            R4.transform.position = BR4.transform.position;
            source.clip = correct;
            source.Play();
            R4correct = true;
   
        }
        else
        {
            R4.transform.position = R4InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropR5()
    {
        float Distance = Vector3.Distance(R5.transform.position, BR5.transform.position);
        if (Distance < 50)
        {
            R5.transform.position = BR5.transform.position;
            source.clip = correct;
            source.Play();
            R5correct = true;
   
        }
        else
        {
            R5.transform.position = R5InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    

    public void DropR6()
    {
        float Distance = Vector3.Distance(R6.transform.position, BR6.transform.position);
        if (Distance < 50)
        {
            R6.transform.position = BR6.transform.position;
            source.clip = correct;
            source.Play();
            R6correct = true;
   
        }
        else
        {
            R6.transform.position = R6InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropR7()
    {
        float Distance = Vector3.Distance(R7.transform.position, BR7.transform.position);
        if (Distance < 50)
        {
            R7.transform.position = BR7.transform.position;
            source.clip = correct;
            source.Play();
            R7correct = true;
   
        }
        else
        {
            R7.transform.position = R7InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(R1correct && R2correct && R3correct && R4correct && R5correct && R6correct && R7correct)
        {
            Debug.Log("You win");
            {Invoke ("MostrarFigura", 0.1f); }
            {Invoke ("Desaparecerfichas", 0.2f); }
            {Invoke ("Armado", 3f); }
        }
        
    }

    void MostrarFigura()
    { 
        ImagenFormada.SetActive(true);
    }

    void Desaparecerfichas()
    { 
        R1.SetActive(false);
        R2.SetActive(false);
        R3.SetActive(false);
        R4.SetActive(false);
        R5.SetActive(false);
        R6.SetActive(false);
        R7.SetActive(false);
        BR1.SetActive(false);
        BR2.SetActive(false);
        BR3.SetActive(false);
        BR4.SetActive(false);
        BR5.SetActive(false);
        BR6.SetActive(false);
        BR7.SetActive(false);
    }

    void Armado()
    { 
        pantallaContinuaraR.SetActive(true);
    }
}
