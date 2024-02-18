using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    [SerializeField]
    public GameObject manzana;
    public GameObject prefab;
    public GameObject prefab2;
    

    private GameObject createdObject;
    private GameObject createdObject2;
    private GameObject createdObject3;

    // Instantiate the Prefab somewhere between -10.0 and 10.0 on the x-z plane
    void Start()
    {
        createObject();
        createObject2();
        createObject3();
    }

    void createObject()
    {
        
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 10, Random.Range(-10.0f, 10.0f));
        createdObject = Instantiate(manzana, position, Quaternion.identity)as GameObject;
        Invoke ("destroyObject", 2.7f);

        
    }

    void createObject2()
    {
        
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 10, Random.Range(-10.0f, 10.0f));
        createdObject2 = Instantiate(prefab, position, Quaternion.identity)as GameObject;
        Invoke ("destroyObject2", 3.0f);
    }

    void createObject3()
    {
        
        Vector3 position = new Vector3(Random.Range(-10.0f, 10.0f), 10, Random.Range(-10.0f, 10.0f));
        createdObject3 =  Instantiate(prefab2, position, Quaternion.identity)as GameObject;
        Invoke ("destroyObject3", 5.0f);
    }



    private void destroyObject()
    {
        Destroy (createdObject);
        Invoke ("createObject", 0.1f);
    }

    private void destroyObject2()
    {
        Destroy (createdObject2);
        Invoke ("createObject2", 0.1f);
    }

    private void destroyObject3()
    {
        Destroy (createdObject3);
        Invoke ("createObject3", 0.1f);
    }

 
}
