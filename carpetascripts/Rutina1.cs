using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rutina1 : MonoBehaviour
{
    public GameObject R11, R12, R13,  BR11, BR12, BR13;
    Vector2 CR11InitialPos, CR12InitialPos, CR13InitialPos;
    public GameObject pantallaContinuarR1E;
    bool R11correct, R12correct, R13correct = false;
    // Start is called before the first frame update
    void Start()
    {
        CR11InitialPos = R11.transform.position;
        CR12InitialPos = R12.transform.position;
        CR13InitialPos = R13.transform.position;
        

        pantallaContinuarR1E.gameObject.SetActive(false);
        
    }

    public void DragR11()
    {
        R11.transform.position = Input.mousePosition;
    }

    public void DragR12()
    {
        R12.transform.position = Input.mousePosition;
    }

    public void DragR13()
    {
        R13.transform.position = Input.mousePosition;
    }

    public void DropR11()
    {
        float Distance = Vector3.Distance(R11.transform.position, BR11.transform.position);
        if (Distance < 50)
        {
            R11.transform.position = BR11.transform.position;
            R11correct = true;
            
        }

        float Distance2 = Vector3.Distance(R11.transform.position, BR12.transform.position);
        if (Distance2 < 50)
        {
            R11.transform.position = BR12.transform.position;            
        }

        float Distance3 = Vector3.Distance(R11.transform.position, BR13.transform.position);
        if (Distance3 < 50)
        {
            R11.transform.position = BR13.transform.position;            
        }

    }

    public void DropR12()
    {
        float Distance = Vector3.Distance(R12.transform.position, BR12.transform.position);
        if (Distance < 50)
        {
            R12.transform.position = BR12.transform.position;
            R12correct = true;
            
        }

        float Distance2 = Vector3.Distance(R12.transform.position, BR11.transform.position);
        if (Distance2 < 50)
        {
            R12.transform.position = BR11.transform.position;            
        }

        float Distance3 = Vector3.Distance(R12.transform.position, BR13.transform.position);
        if (Distance3 < 50)
        {
            R12.transform.position = BR13.transform.position;            
        }

    }

    public void DropR13()
    {
        float Distance = Vector3.Distance(R13.transform.position, BR13.transform.position);
        if (Distance < 50)
        {
            R13.transform.position = BR13.transform.position;
            R13correct = true;
            
        }

        float Distance2 = Vector3.Distance(R13.transform.position, BR11.transform.position);
        if (Distance2 < 50)
        {
            R13.transform.position = BR11.transform.position;            
        }

        float Distance3 = Vector3.Distance(R13.transform.position, BR12.transform.position);
        if (Distance3 < 50)
        {
            R13.transform.position = BR12.transform.position;            
        }

    }

    public void RevisarR1()
    {
        if(R11correct && R12correct && R13correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarR1", 0.5f); }
        }

        if(R11correct == false)
        {
            R11.transform.position = CR11InitialPos;
            
        }

        if(R12correct == false)
        {
            R12.transform.position = CR12InitialPos;
            
        }

        if(R13correct == false)
        {
            R13.transform.position = CR13InitialPos;
            
        }


    }
    
    void ContinuarR1()
    { 
        pantallaContinuarR1E.gameObject.SetActive(true); 
    }

}
