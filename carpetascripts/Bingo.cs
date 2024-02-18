using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bingo : MonoBehaviour
{
     public GameObject A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13;
     public GameObject oA1;
     public GameObject I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13;
     

     

     

    Vector2 A1InitialPos, A2InitialPos, A3InitialPos, A4InitialPos, A5InitialPos, A6InitialPos, A7InitialPos,
    A8InitialPos, A9InitialPos, A10InitialPos, A11InitialPos, A12InitialPos, A13InitialPos;
    Vector2 oA1InitialPos;
    public GameObject pantallaContinuara;
    
    public GameObject timer;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    public int bingo;
    private int puntosBingo;

    bool A1correct, A2correct, A3correct, A4correct, A5correct, A6correct, A7correct, A8correct, A9correct, A10correct, A11correct, A12correct, A13correct = false;
    private int puntosNegativos;
    bool oA1correct;

    void Start()
    {
        A1InitialPos = A1.transform.position;
        A2InitialPos = A2.transform.position;
        A3InitialPos = A3.transform.position;
        A4InitialPos = A4.transform.position;
        A5InitialPos = A5.transform.position;
        A6InitialPos = A6.transform.position;
        A7InitialPos = A7.transform.position;
        A8InitialPos = A8.transform.position;
        A9InitialPos = A9.transform.position;
        A10InitialPos = A10.transform.position;
        A11InitialPos = A11.transform.position;
        A12InitialPos = A12.transform.position;
        A13InitialPos = A13.transform.position;
        oA1InitialPos = oA1.transform.position;
        pantallaContinuara.gameObject.SetActive(false);
        I2.gameObject.SetActive(false);
        I3.gameObject.SetActive(false);
        I4.gameObject.SetActive(false);
        I5.gameObject.SetActive(false);
        I6.gameObject.SetActive(false);
        I7.gameObject.SetActive(false);
        I8.gameObject.SetActive(false);
        I9.gameObject.SetActive(false);
        I10.gameObject.SetActive(false);
        I11.gameObject.SetActive(false);
        I12.gameObject.SetActive(false);
        I13.gameObject.SetActive(false);

        
        
        

        

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

    public void DragA7()
    {
        A7.transform.position = Input.mousePosition;
    }

    public void DragA8()
    {
        A8.transform.position = Input.mousePosition;
    }

    public void DragA9()
    {
        A9.transform.position = Input.mousePosition;
    }

    public void DragA10()
    {
        A10.transform.position = Input.mousePosition;
    }

    public void DragA11()
    {
        A11.transform.position = Input.mousePosition;
    }

    public void DragA12()
    {
        A12.transform.position = Input.mousePosition;
    }

    public void DragA13()
    {
        A13.transform.position = Input.mousePosition;
    }

    public void DragoA1()
    {
        oA1.transform.position = Input.mousePosition;
        
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
            puntosBingo++;
            A2.gameObject.SetActive(true);
            I2.gameObject.SetActive(true);
            I1.gameObject.SetActive(false);
            
            
            
        }
        else
        {
            A1.transform.position = A1InitialPos;
            source.clip = incorrect;
            source.Play();
            
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
            puntosBingo++;
            A3.gameObject.SetActive(true);
            I3.gameObject.SetActive(true);
            I2.gameObject.SetActive(false);
        }
        else
        {
            A2.transform.position = A2InitialPos;
            source.clip = incorrect;
            source.Play();
            
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
            puntosBingo++;
            A4.gameObject.SetActive(true);
            I4.gameObject.SetActive(true);
            I3.gameObject.SetActive(false);
        }
        else
        {
            A3.transform.position = A3InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA4()
    {
        float Distance = Vector3.Distance(A4.transform.position, B4.transform.position);
        if (Distance < 50)
        {
            A4.transform.position = B4.transform.position;
            source.clip = correct;
            source.Play();
            A4correct = true;
            puntosBingo++;
            A5.gameObject.SetActive(true);
            I5.gameObject.SetActive(true);
            I4.gameObject.SetActive(false);
        }
        else
        {
            A4.transform.position = A4InitialPos;
            source.clip = incorrect;
            source.Play();
            
            
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
            puntosBingo++;
            A6.gameObject.SetActive(true);
            I6.gameObject.SetActive(true);
            I5.gameObject.SetActive(false);
        }
        else
        {
            A5.transform.position = A5InitialPos;
            source.clip = incorrect;
            source.Play();
            
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
            puntosBingo++;
            A7.gameObject.SetActive(true);
            I7.gameObject.SetActive(true);
            I6.gameObject.SetActive(false);
        }
        else
        {
            A6.transform.position = A6InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA7()
    {
        float Distance = Vector3.Distance(A7.transform.position, B7.transform.position);
        if (Distance < 50)
        {
            A7.transform.position = B7.transform.position;
            source.clip = correct;
            source.Play();
            A7correct = true;
            puntosBingo++;
            A8.gameObject.SetActive(true);
            I8.gameObject.SetActive(true);
            I7.gameObject.SetActive(false);
        }
        else
        {
            A7.transform.position = A7InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA8()
    {
        float Distance = Vector3.Distance(A8.transform.position, B8.transform.position);
        if (Distance < 50)
        {
            A8.transform.position = B8.transform.position;
            source.clip = correct;
            source.Play();
            A8correct = true;
            puntosBingo++;
            A9.gameObject.SetActive(true);
            I9.gameObject.SetActive(true);
            I8.gameObject.SetActive(false);
        }
        else
        {
            A8.transform.position = A8InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA9()
    {
        float Distance = Vector3.Distance(A9.transform.position, B9.transform.position);
        if (Distance < 50)
        {
            A9.transform.position = B9.transform.position;
            source.clip = correct;
            source.Play();
            A9correct = true;
            puntosBingo++;
            A10.gameObject.SetActive(true);
            I10.gameObject.SetActive(true);
            I9.gameObject.SetActive(false);
        }
        else
        {
            A9.transform.position = A9InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA10()
    {
        float Distance = Vector3.Distance(A10.transform.position, B10.transform.position);
        if (Distance < 50)
        {
            A10.transform.position = B10.transform.position;
            source.clip = correct;
            source.Play();
            A10correct = true;
            puntosBingo++;
            A11.gameObject.SetActive(true);
            I11.gameObject.SetActive(true);
            I10.gameObject.SetActive(false);
        }
        else
        {
            A10.transform.position = A10InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropoA1()
    {
        float Distance = Vector3.Distance(oA1.transform.position, B1.transform.position);
        if (Distance < 50)
        {
            oA1.transform.position = B1.transform.position;
            source.clip = correct;
            source.Play();
            oA1correct = true;
            puntosBingo++;
        }
        else
        {
            oA1.transform.position = oA1InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA11()
    {
        float Distance = Vector3.Distance(A11.transform.position, B11.transform.position);
        if (Distance < 50)
        {
            A11.transform.position = B11.transform.position;
            source.clip = correct;
            source.Play();
            A11correct = true;
            puntosBingo++;
            A12.gameObject.SetActive(true);
            I12.gameObject.SetActive(true);
            I11.gameObject.SetActive(false);
        }
        else
        {
            A11.transform.position = A11InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA12()
    {
        float Distance = Vector3.Distance(A12.transform.position, B12.transform.position);
        if (Distance < 50)
        {
            A12.transform.position = B12.transform.position;
            source.clip = correct;
            source.Play();
            A12correct = true;
            puntosBingo++;
            A13.gameObject.SetActive(true);
            I13.gameObject.SetActive(true);
            I12.gameObject.SetActive(false);
        }
        else
        {
            A12.transform.position = A12InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    public void DropA13()
    {
        float Distance = Vector3.Distance(A13.transform.position, B13.transform.position);
        if (Distance < 50)
        {
            A13.transform.position = B13.transform.position;
            source.clip = correct;
            source.Play();
            A13correct = true;
            puntosBingo++;
        }
        else
        {
            A13.transform.position = A13InitialPos;
            source.clip = incorrect;
            source.Play();
            
        }
    }

    void Update()
    {
        //if(puntosBingo == bingo){Debug.Log("You win");{pantallaContinuara.gameObject.SetActive(true); }{timer.gameObject.SetActive(false); }   }

        if(A1correct && A2correct && A3correct && A4correct && A5correct && A6correct && A7correct && A8correct && A9correct && A10correct && A11correct && A12correct && A13correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarB", 1.0f); }
            {timer.gameObject.SetActive(false); }   
        }

        if(oA1correct && A2correct && A3correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarB", 1.0f); }
            {timer.gameObject.SetActive(false); }

        }

        if(oA1correct  && A4correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarB", 1.0f); }
            {timer.gameObject.SetActive(false); }

        }

       

    }

    void ContinuarB()
    { 
        pantallaContinuara.gameObject.SetActive(true); 
    }



}
