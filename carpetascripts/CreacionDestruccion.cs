using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionDestruccion : MonoBehaviour
{
    [SerializeField]
    public GameObject objectToCreate;
    public GameObject objectToCreate2;
    [SerializeField]
    public GameObject position;
    public GameObject position2;

    private GameObject createdObject;
    private GameObject createdObject2;
    

    // Start is called before the first frame update
    void Start()
    {
        createObject();
    }

    private void createObject()
    {
        createdObject = Instantiate (objectToCreate, position.transform);
        createdObject2 = Instantiate (objectToCreate2, position2.transform);
        Invoke ("destroyObject", 4f);
    }
    
    private void destroyObject()
    {
        Destroy (createdObject);
        Invoke ("createObject", 0.1f);
    }

}

