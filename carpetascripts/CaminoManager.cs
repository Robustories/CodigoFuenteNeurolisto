using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminoManager : MonoBehaviour
{
    public GameObject PipeHolder;
    public GameObject[] Pipes;

    [SerializeField]
    int totalPipes = 0;

    [SerializeField]
    int correctedPipes = 0;

    public GameObject pantallaCaminoCompleto;
    // Start is called before the first frame update
    
    void Start()
    {
        pantallaCaminoCompleto.SetActive(false);
        
        totalPipes = PipeHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length  ; i ++)
        {
            Pipes[i] = PipeHolder.transform.GetChild(i).gameObject;
        }
    }

    public void CorrectMove()
    {
        correctedPipes += 1;

        Debug.Log("Correct Move");
        

        if (correctedPipes == totalPipes)
        {
            Debug.Log("You Win");
            Invoke ("ContinuarCa", 0.8f);
        }
    }

    public void WrongMove()
    {
        correctedPipes -= 1;
    }

    void ContinuarCa()
    { 
        pantallaCaminoCompleto.SetActive(true);
    }
}
