using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentoEncantado : MonoBehaviour
{
    public GameObject C1, C2, C3, C4, CB1, CB2, CB3, CB4;
    Vector2 C1InitialPos, C2InitialPos, C3InitialPos, C4InitialPos;
    public GameObject pantallaContinuarCE;
    bool C1correct, C2correct, C3correct, C4correct   = false;
    // Start is called before the first frame update

    
    void Start()
    {
        C1InitialPos = C1.transform.position;
        C2InitialPos = C2.transform.position;
        C3InitialPos = C3.transform.position;
        C4InitialPos = C4.transform.position;

        pantallaContinuarCE.gameObject.SetActive(false);
        
    }

    public void DragC1()
    {
        C1.transform.position = Input.mousePosition;
    }

    public void DragC2()
    {
        C2.transform.position = Input.mousePosition;
    }

    public void DragC3()
    {
        C3.transform.position = Input.mousePosition;
    }

    public void DragC4()
    {
        C4.transform.position = Input.mousePosition;
    }

    public void DropC1()
    {
        float Distance = Vector3.Distance(C1.transform.position, CB1.transform.position);
        if (Distance < 50)
        {
            C1.transform.position = CB1.transform.position;
            C1correct = true;
            
        }

        float Distance2 = Vector3.Distance(C1.transform.position, CB2.transform.position);
        if (Distance2 < 50)
        {
            C1.transform.position = CB2.transform.position;            
        }

        float Distance3 = Vector3.Distance(C1.transform.position, CB3.transform.position);
        if (Distance3 < 50)
        {
            C1.transform.position = CB3.transform.position;            
        }

        float Distance4 = Vector3.Distance(C1.transform.position, CB4.transform.position);
        if (Distance4 < 50)
        {
            C1.transform.position = CB4.transform.position;            
        }
    }

    public void DropC2()
    {
        float Distance = Vector3.Distance(C2.transform.position, CB2.transform.position);
        if (Distance < 50)
        {
            C2.transform.position = CB2.transform.position;
            C2correct = true;
            
        }

        float Distance2 = Vector3.Distance(C2.transform.position, CB1.transform.position);
        if (Distance2 < 50)
        {
            C2.transform.position = CB1.transform.position;            
        }

        float Distance3 = Vector3.Distance(C2.transform.position, CB3.transform.position);
        if (Distance3 < 50)
        {
            C2.transform.position = CB3.transform.position;            
        }

        float Distance4 = Vector3.Distance(C2.transform.position, CB4.transform.position);
        if (Distance4 < 50)
        {
            C2.transform.position = CB4.transform.position;            
        }
    }

    public void DropC3()
    {
        float Distance = Vector3.Distance(C3.transform.position, CB3.transform.position);
        if (Distance < 50)
        {
            C3.transform.position = CB3.transform.position;
            C3correct = true;
            
        }

        float Distance2 = Vector3.Distance(C3.transform.position, CB1.transform.position);
        if (Distance2 < 50)
        {
            C3.transform.position = CB1.transform.position;            
        }

        float Distance3 = Vector3.Distance(C3.transform.position, CB2.transform.position);
        if (Distance3 < 50)
        {
            C3.transform.position = CB2.transform.position;            
        }

        float Distance4 = Vector3.Distance(C3.transform.position, CB4.transform.position);
        if (Distance4 < 50)
        {
            C3.transform.position = CB4.transform.position;            
        }
    }

    public void DropC4()
    {
        float Distance = Vector3.Distance(C4.transform.position, CB4.transform.position);
        if (Distance < 50)
        {
            C4.transform.position = CB4.transform.position;
            C4correct = true;
            
        }

        float Distance2 = Vector3.Distance(C4.transform.position, CB1.transform.position);
        if (Distance2 < 50)
        {
            C4.transform.position = CB1.transform.position;            
        }

        float Distance3 = Vector3.Distance(C4.transform.position, CB2.transform.position);
        if (Distance3 < 50)
        {
            C4.transform.position = CB2.transform.position;            
        }

        float Distance4 = Vector3.Distance(C4.transform.position, CB3.transform.position);
        if (Distance4 < 50)
        {
            C4.transform.position = CB3.transform.position;            
        }
    }

    public void Revisar()
    {
        if(C1correct && C2correct && C3correct && C4correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarCE", 0.5f); }
        }

        if(C1correct == false)
        {
            C1.transform.position = C1InitialPos;
            
        }

        if(C2correct == false)
        {
            C2.transform.position = C2InitialPos;
            
        }

        if(C3correct == false)
        {
            C3.transform.position = C3InitialPos;
            
        }

        if(C4correct == false)
        {
            C4.transform.position = C4InitialPos;
            
        }


    }

    void ContinuarCE()
    { 
        pantallaContinuarCE.gameObject.SetActive(true); 
    }
}
