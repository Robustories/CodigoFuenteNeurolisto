using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rutina3 : MonoBehaviour
{
    public GameObject R31, R32, R33, R34, R35, R36,  BR31, BR32, BR33, BR34, BR35, BR36;
    Vector2 CR31InitialPos, CR32InitialPos, CR33InitialPos, CR34InitialPos, CR35InitialPos, CR36InitialPos;
    public GameObject pantallaContinuarR3E;
    bool R31correct, R32correct, R33correct, R34correct, R35correct, R36correct  = false;
    // Start is called before the first frame update
    void Start()
    {
        CR31InitialPos = R31.transform.position;
        CR32InitialPos = R32.transform.position;
        CR33InitialPos = R33.transform.position;
        CR34InitialPos = R34.transform.position;
        CR35InitialPos = R35.transform.position;
        CR36InitialPos = R36.transform.position;
        

        pantallaContinuarR3E.gameObject.SetActive(false);
        
    }

    public void DragR31()
    {
        R31.transform.position = Input.mousePosition;
    }

    public void DragR32()
    {
        R32.transform.position = Input.mousePosition;
    }

    public void DragR33()
    {
        R33.transform.position = Input.mousePosition;
    }

    public void DragR34()
    {
        R34.transform.position = Input.mousePosition;
    }

    public void DragR35()
    {
        R35.transform.position = Input.mousePosition;
    }

    public void DragR36()
    {
        R36.transform.position = Input.mousePosition;
    }

    public void DropR31()
    {
        float Distance = Vector3.Distance(R31.transform.position, BR31.transform.position);
        if (Distance < 50)
        {
            R31.transform.position = BR31.transform.position;
            R31correct = true;
            
        }

        float Distance2 = Vector3.Distance(R31.transform.position, BR32.transform.position);
        if (Distance2 < 50)
        {
            R31.transform.position = BR32.transform.position;            
        }

        float Distance3 = Vector3.Distance(R31.transform.position, BR33.transform.position);
        if (Distance3 < 50)
        {
            R31.transform.position = BR33.transform.position;            
        }

        float Distance4 = Vector3.Distance(R31.transform.position, BR34.transform.position);
        if (Distance4 < 50)
        {
            R31.transform.position = BR34.transform.position;            
        }

        float Distance5 = Vector3.Distance(R31.transform.position, BR35.transform.position);
        if (Distance5 < 50)
        {
            R31.transform.position = BR35.transform.position;            
        }

        float Distance6 = Vector3.Distance(R31.transform.position, BR36.transform.position);
        if (Distance6 < 50)
        {
            R31.transform.position = BR36.transform.position;            
        }

    }

    public void DropR32()
    {
        float Distance = Vector3.Distance(R32.transform.position, BR32.transform.position);
        if (Distance < 50)
        {
            R32.transform.position = BR32.transform.position;
            R32correct = true;
            
        }

        float Distance2 = Vector3.Distance(R32.transform.position, BR31.transform.position);
        if (Distance2 < 50)
        {
            R32.transform.position = BR31.transform.position;            
        }

        float Distance3 = Vector3.Distance(R32.transform.position, BR33.transform.position);
        if (Distance3 < 50)
        {
            R32.transform.position = BR33.transform.position;            
        }

        float Distance4 = Vector3.Distance(R32.transform.position, BR34.transform.position);
        if (Distance4 < 50)
        {
            R32.transform.position = BR34.transform.position;            
        }

        float Distance5 = Vector3.Distance(R32.transform.position, BR35.transform.position);
        if (Distance5 < 50)
        {
            R32.transform.position = BR35.transform.position;            
        }

        float Distance6 = Vector3.Distance(R32.transform.position, BR36.transform.position);
        if (Distance6 < 50)
        {
            R32.transform.position = BR36.transform.position;            
        }

    }

    public void DropR33()
    {
        float Distance = Vector3.Distance(R33.transform.position, BR33.transform.position);
        if (Distance < 50)
        {
            R33.transform.position = BR33.transform.position;
            R33correct = true;
            
        }

        float Distance2 = Vector3.Distance(R33.transform.position, BR31.transform.position);
        if (Distance2 < 50)
        {
            R33.transform.position = BR31.transform.position;            
        }

        float Distance3 = Vector3.Distance(R33.transform.position, BR32.transform.position);
        if (Distance3 < 50)
        {
            R33.transform.position = BR32.transform.position;            
        }

        float Distance4 = Vector3.Distance(R33.transform.position, BR34.transform.position);
        if (Distance4 < 50)
        {
            R33.transform.position = BR34.transform.position;            
        }

        float Distance5 = Vector3.Distance(R33.transform.position, BR35.transform.position);
        if (Distance5 < 50)
        {
            R33.transform.position = BR35.transform.position;            
        }

        float Distance6 = Vector3.Distance(R33.transform.position, BR36.transform.position);
        if (Distance6 < 50)
        {
            R33.transform.position = BR36.transform.position;            
        }

    }

    public void DropR34()
    {
        float Distance = Vector3.Distance(R34.transform.position, BR34.transform.position);
        if (Distance < 50)
        {
            R34.transform.position = BR34.transform.position;
            R34correct = true;
            
        }

        float Distance2 = Vector3.Distance(R34.transform.position, BR31.transform.position);
        if (Distance2 < 50)
        {
            R34.transform.position = BR31.transform.position;            
        }

        float Distance3 = Vector3.Distance(R34.transform.position, BR32.transform.position);
        if (Distance3 < 50)
        {
            R34.transform.position = BR32.transform.position;            
        }

        float Distance4 = Vector3.Distance(R34.transform.position, BR33.transform.position);
        if (Distance4 < 50)
        {
            R34.transform.position = BR33.transform.position;            
        }

        float Distance5 = Vector3.Distance(R34.transform.position, BR35.transform.position);
        if (Distance5 < 50)
        {
            R34.transform.position = BR35.transform.position;            
        }

        float Distance6 = Vector3.Distance(R34.transform.position, BR36.transform.position);
        if (Distance6 < 50)
        {
            R34.transform.position = BR36.transform.position;            
        }

    }

    public void DropR35()
    {
        float Distance = Vector3.Distance(R35.transform.position, BR35.transform.position);
        if (Distance < 50)
        {
            R35.transform.position = BR35.transform.position;
            R35correct = true;
            
        }

        float Distance2 = Vector3.Distance(R35.transform.position, BR31.transform.position);
        if (Distance2 < 50)
        {
            R35.transform.position = BR31.transform.position;            
        }

        float Distance3 = Vector3.Distance(R35.transform.position, BR32.transform.position);
        if (Distance3 < 50)
        {
            R35.transform.position = BR32.transform.position;            
        }

        float Distance4 = Vector3.Distance(R35.transform.position, BR33.transform.position);
        if (Distance4 < 50)
        {
            R35.transform.position = BR33.transform.position;            
        }

        float Distance5 = Vector3.Distance(R35.transform.position, BR34.transform.position);
        if (Distance5 < 50)
        {
            R35.transform.position = BR34.transform.position;            
        }

        float Distance6 = Vector3.Distance(R35.transform.position, BR36.transform.position);
        if (Distance6 < 50)
        {
            R35.transform.position = BR36.transform.position;            
        }

    }

    public void DropR36()
    {
        float Distance = Vector3.Distance(R36.transform.position, BR36.transform.position);
        if (Distance < 50)
        {
            R36.transform.position = BR36.transform.position;
            R36correct = true;
            
        }

        float Distance2 = Vector3.Distance(R36.transform.position, BR31.transform.position);
        if (Distance2 < 50)
        {
            R36.transform.position = BR31.transform.position;            
        }

        float Distance3 = Vector3.Distance(R36.transform.position, BR32.transform.position);
        if (Distance3 < 50)
        {
            R36.transform.position = BR32.transform.position;            
        }

        float Distance4 = Vector3.Distance(R36.transform.position, BR33.transform.position);
        if (Distance4 < 50)
        {
            R36.transform.position = BR33.transform.position;            
        }

        float Distance5 = Vector3.Distance(R36.transform.position, BR34.transform.position);
        if (Distance5 < 50)
        {
            R36.transform.position = BR34.transform.position;            
        }

        float Distance6 = Vector3.Distance(R36.transform.position, BR36.transform.position);
        if (Distance6 < 50)
        {
            R36.transform.position = BR36.transform.position;            
        }

    }

    public void RevisarR3()
    {
        if(R31correct && R32correct && R33correct && R34correct && R35correct)
        {
            Debug.Log("You win");
            {Invoke ("ContinuarR3", 0.5f); }
        }

        if(R31correct == false)
        {
            R31.transform.position = CR31InitialPos;
            
        }

        if(R32correct == false)
        {
            R32.transform.position = CR32InitialPos;
            
        }

        if(R33correct == false)
        {
            R33.transform.position = CR33InitialPos;
            
        }

        if(R34correct == false)
        {
            R34.transform.position = CR34InitialPos;
            
        }

        if(R35correct == false)
        {
            R35.transform.position = CR35InitialPos;
            
        }

        if(R36correct == false)
        {
            R36.transform.position = CR36InitialPos;
            
        }


    }
    
    void ContinuarR3()

    { 
        pantallaContinuarR3E.gameObject.SetActive(true); 
    }
}
