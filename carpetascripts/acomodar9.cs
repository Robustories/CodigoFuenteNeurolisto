using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acomodar9 : MonoBehaviour
{
    public GameObject A91, A92, A93, A94, A95, A96, A97, A98, A99, B91, B92, B93, B94, B95, B96, B97, B98, B99;
    Vector2 A91InitialPos, A92InitialPos, A93InitialPos, A94InitialPos, A95InitialPos, A96InitialPos, A97InitialPos, A98InitialPos, A99InitialPos;
    public GameObject pantallaContinuar9;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    // Start is called before the first frame update
    bool A91correct, A92correct, A93correct, A94correct, A95correct, A96correct, A97correct, A98correct, A99correct  = false;
    void Start()
    {
        A91InitialPos = A91.transform.position;
        A92InitialPos = A92.transform.position;
        A93InitialPos = A93.transform.position;
        A94InitialPos = A94.transform.position;
        A95InitialPos = A95.transform.position;
        A96InitialPos = A96.transform.position;
        A97InitialPos = A97.transform.position;
        A98InitialPos = A98.transform.position;
        A99InitialPos = A99.transform.position;

        pantallaContinuar9.gameObject.SetActive(false);
        
    }

    public void DragA91()
    {
        A91.transform.position = Input.mousePosition;
    }

    public void DragA92()
    {
        A92.transform.position = Input.mousePosition;
    }

    public void DragA93()
    {
        A93.transform.position = Input.mousePosition;
    }

    public void DragA94()
    {
        A94.transform.position = Input.mousePosition;
    }

    public void DragA95()
    {
        A95.transform.position = Input.mousePosition;
    }

    public void DragA96()
    {
        A96.transform.position = Input.mousePosition;
    }

    public void DragA97()
    {
        A97.transform.position = Input.mousePosition;
    }

    public void DragA98()
    {
        A98.transform.position = Input.mousePosition;
    }

    public void DragA99()
    {
        A99.transform.position = Input.mousePosition;
    }

    public void DropA91()
    {
        float Distance = Vector3.Distance(A91.transform.position, B91.transform.position);
        if (Distance < 50)
        {
            A91.transform.position = B91.transform.position;
            source.clip = correct;
            source.Play();
            A91correct = true;
        }
        else
        {
            A91.transform.position = A91InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA92()
    {
        float Distance = Vector3.Distance(A92.transform.position, B92.transform.position);
        if (Distance < 50)
        {
            A92.transform.position = B92.transform.position;
            source.clip = correct;
            source.Play();
            A92correct = true;
        }
        else
        {
            A92.transform.position = A92InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA93()
    {
        float Distance = Vector3.Distance(A93.transform.position, B93.transform.position);
        if (Distance < 50)
        {
            A93.transform.position = B93.transform.position;
            source.clip = correct;
            source.Play();
            A93correct = true;
        }
        else
        {
            A93.transform.position = A93InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA94()
    {
        float Distance = Vector3.Distance(A94.transform.position, B94.transform.position);
        if (Distance < 50)
        {
            A94.transform.position = B94.transform.position;
            source.clip = correct;
            source.Play();
            A94correct = true;
        }
        else
        {
            A94.transform.position = A94InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    
    public void DropA95()
    {
        float Distance = Vector3.Distance(A95.transform.position, B95.transform.position);
        if (Distance < 50)
        {
            A95.transform.position = B95.transform.position;
            source.clip = correct;
            source.Play();
            A95correct = true;
        }
        else
        {
            A95.transform.position = A95InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA96()
    {
        float Distance = Vector3.Distance(A96.transform.position, B96.transform.position);
        if (Distance < 50)
        {
            A96.transform.position = B96.transform.position;
            source.clip = correct;
            source.Play();
            A96correct = true;
        }
        else
        {
            A96.transform.position = A96InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA97()
    {
        float Distance = Vector3.Distance(A97.transform.position, B97.transform.position);
        if (Distance < 50)
        {
            A97.transform.position = B97.transform.position;
            source.clip = correct;
            source.Play();
            A97correct = true;
        }
        else
        {
            A97.transform.position = A97InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA98()
    {
        float Distance = Vector3.Distance(A98.transform.position, B98.transform.position);
        if (Distance < 50)
        {
            A98.transform.position = B98.transform.position;
            source.clip = correct;
            source.Play();
            A98correct = true;
        }
        else
        {
            A98.transform.position = A98InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropA99()
    {
        float Distance = Vector3.Distance(A99.transform.position, B99.transform.position);
        if (Distance < 50)
        {
            A99.transform.position = B99.transform.position;
            source.clip = correct;
            source.Play();
            A99correct = true;
        }
        else
        {
            A99.transform.position = A99InitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(A91correct && A92correct && A93correct && A94correct && A95correct && A96correct && A97correct && A98correct && A99correct)
        {
            Debug.Log("You win");
            {Invoke ("Continuar9", 0.7f); }
        }
        
    }

    void Continuar9()
    { 
        pantallaContinuar9.gameObject.SetActive(true); 
    }
}
