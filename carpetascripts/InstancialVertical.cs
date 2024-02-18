using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstancialVertical : MonoBehaviour
{
    [SerializeField]
    public GameObject mosquito;
    public GameObject abeja;
    private GameObject mosquitoCreado;
    private GameObject abejaCreada;
    // Start is called before the first frame update
    void Start()
    {
        createAbeja();
        createMosquito();
    }

    // Update is called once per frame

    void createMosquito()
    {
        
        Vector3 position = new Vector3(-9, Random.Range(-5.0f, 5.0f), 0);
        mosquitoCreado= Instantiate(mosquito, position, Quaternion.identity);
        Invoke ("destroyMosquito", 3f);

        
    }

    void createAbeja()
    {
        
        Vector3 position = new Vector3(-9, Random.Range(-5.0f, 5.0f), 0);
        abejaCreada = Instantiate(abeja, position, Quaternion.identity);
        Invoke ("destroyAbeja", 4f);
    }

    private void destroyMosquito()
    {
        Destroy (mosquitoCreado);
        Invoke ("createMosquito", 0.1f);
    }

    private void destroyAbeja()
    {
        Destroy (abejaCreada);
        Invoke ("createAbeja", 0.1f);
    }
}
