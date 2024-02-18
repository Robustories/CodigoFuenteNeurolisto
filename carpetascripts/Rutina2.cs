using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rutina2 : MonoBehaviour
{
    public GameObject R21, R22, R23, R24, R25,  BR21, BR22, BR23, BR24, BR25;
    Vector2 CR21InitialPos, CR22InitialPos, CR23InitialPos, CR24InitialPos, CR25InitialPos;
    public GameObject pantallaContinuarR2E;
    bool R21correct, R22correct, R23correct, R24correct, R25correct  = false;
    // Start is called before the first frame update
    void Start()
    {
        CR21InitialPos = R21.transform.position;
        CR22InitialPos = R22.transform.position;
        CR23InitialPos = R23.transform.position;
        CR24InitialPos = R24.transform.position;
        CR25InitialPos = R25.transform.position;
        

        pantallaContinuarR2E.gameObject.SetActive(false);
    }

    public void DragR21()
    {
        R21.transform.position = Input.mousePosition;
    }

    public void DragR22()
    {
        R22.transform.position = Input.mousePosition;
    }

    public void DragR23()
    {
        R23.transform.position = Input.mousePosition;
    }

    public void DragR24()
    {
        R24.transform.position = Input.mousePosition;
    }

    public void DragR25()
    {
        R25.transform.position = Input.mousePosition;
    }

    public void DropR21()
    {
        float Distance = Vector3.Distance(R21.transform.position, BR21.transform.position);
        if (Distance < 50)
        {
            R21.transform.position = BR21.transform.position;
            R21correct = true;
            
        }

        float Distance2 = Vector3.Distance(R21.transform.position, BR22.transform.position);
        if (Distance2 < 50)
        {
            R21.transform.position = BR22.transform.position;            
        }

        float Distance3 = Vector3.Distance(R21.transform.position, BR23.transform.position);
        if (Distance3 < 50)
        {
            R21.transform.position = BR23.transform.position;            
        }

        float Distance4 = Vector3.Distance(R21.transform.position, BR24.transform.position);
        if (Distance4 < 50)
        {
            R21.transform.position = BR24.transform.position;            
        }

        float Distance5 = Vector3.Distance(R21.transform.position, BR25.transform.position);
        if (Distance5 < 50)
        {
            R21.transform.position = BR25.transform.position;            
        }

    }

    public void DropR22()
    {
        float Distance = Vector3.Distance(R22.transform.position, BR22.transform.position);
        if (Distance < 50)
        {
            R22.transform.position = BR22.transform.position;
            R22correct = true;
            
        }

        float Distance2 = Vector3.Distance(R22.transform.position, BR21.transform.position);
        if (Distance2 < 50)
        {
            R22.transform.position = BR21.transform.position;            
        }

        float Distance3 = Vector3.Distance(R22.transform.position, BR23.transform.position);
        if (Distance3 < 50)
        {
            R22.transform.position = BR23.transform.position;            
        }

        float Distance4 = Vector3.Distance(R22.transform.position, BR24.transform.position);
        if (Distance4 < 50)
        {
            R22.transform.position = BR24.transform.position;            
        }

        float Distance5 = Vector3.Distance(R22.transform.position, BR25.transform.position);
        if (Distance5 < 50)
        {
            R22.transform.position = BR25.transform.position;            
        }

    }

    public void DropR23()
    {
        float Distance = Vector3.Distance(R23.transform.position, BR23.transform.position);
        if (Distance < 50)
        {
            R23.transform.position = BR23.transform.position;
            R23correct = true;
            
        }

        float Distance2 = Vector3.Distance(R23.transform.position, BR21.transform.position);
        if (Distance2 < 50)
        {
            R23.transform.position = BR21.transform.position;            
        }

        float Distance3 = Vector3.Distance(R23.transform.position, BR22.transform.position);
        if (Distance3 < 50)
        {
            R23.transform.position = BR22.transform.position;            
        }

        float Distance4 = Vector3.Distance(R23.transform.position, BR24.transform.position);
        if (Distance4 < 50)
        {
            R23.transform.position = BR24.transform.position;            
        }

        float Distance5 = Vector3.Distance(R23.transform.position, BR25.transform.position);
        if (Distance5 < 50)
        {
            R23.transform.position = BR25.transform.position;            
        }

    }

    public void DropR24()
    {
        float Distance = Vector3.Distance(R24.transform.position, BR24.transform.position);
        if (Distance < 50)
        {
            R24.transform.position = BR24.transform.position;
            R24correct = true;
            
        }

        float Distance2 = Vector3.Distance(R24.transform.position, BR21.transform.position);
        if (Distance2 < 50)
        {
            R24.transform.position = BR21.transform.position;            
        }

        float Distance3 = Vector3.Distance(R24.transform.position, BR22.transform.position);
        if (Distance3 < 50)
        {
            R24.transform.position = BR22.transform.position;            
        }

        float Distance4 = Vector3.Distance(R24.transform.position, BR23.transform.position);
        if (Distance4 < 50)
        {
            R24.transform.position = BR23.transform.position;            
        }

        float Distance5 = Vector3.Distance(R24.transform.position, BR25.transform.position);
        if (Distance5 < 50)
        {
            R24.transform.position = BR25.transform.position;            
        }

    }

    public void DropR25()
    {
        float Distance = Vector3.Distance(R25.transform.position, BR25.transform.position);
        if (Distance < 50)
        {
            R25.transform.position = BR25.transform.position;
            R25correct = true;
            
        }

        float Distance2 = Vector3.Distance(R25.transform.position, BR21.transform.position);
        if (Distance2 < 50)
        {
            R25.transform.position = BR21.transform.position;            
        }

        float Distance3 = Vector3.Distance(R25.transform.position, BR22.transform.position);
        if (Distance3 < 50)
        {
            R25.transform.position = BR22.transform.position;            
        }

        float Distance4 = Vector3.Distance(R25.transform.position, BR23.transform.position);
        if (Distance4 < 50)
        {
            R25.transform.position = BR23.transform.position;            
        }

        float Distance5 = Vector3.Distance(R25.transform.position, BR24.transform.position);
        if (Distance5 < 50)
        {
            R25.transform.position = BR24.transform.position;            
        }

    }

    public void RevisarR2()
    {
        if(R21correct && R22correct && R23correct && R24correct && R25correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarR2", 0.5f); }
        }

        if(R21correct == false)
        {
            R21.transform.position = CR21InitialPos;
            
        }

        if(R22correct == false)
        {
            R22.transform.position = CR22InitialPos;
            
        }

        if(R23correct == false)
        {
            R23.transform.position = CR23InitialPos;
            
        }

        if(R24correct == false)
        {
            R24.transform.position = CR24InitialPos;
            
        }

        if(R25correct == false)
        {
            R25.transform.position = CR25InitialPos;
            
        }


    }

    void ContinuarR2()
    { 
        pantallaContinuarR2E.gameObject.SetActive(true); 
    }
}
