using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarMariposas : MonoBehaviour
{
    [SerializeField]
    public GameObject mariposa;
    public GameObject abejaprefab;
    private GameObject mariposaCreado;
    private GameObject abejaCreado;

    // Start is called before the first frame update
    void Start()
    {
        createMariposa();
        Invoke("createAbeja", 3f);
    }

    void createMariposa()
    {
        
        Vector3 position = new Vector3(-1, Random.Range(0.2f, 3.0f), Random.Range(-10.0f, 10.0f));
        mariposaCreado= Instantiate(mariposa, position, Quaternion.identity);
        Invoke ("destroyMariposa", 2f);

        
    }

    private void destroyMariposa()
    {
        Destroy (mariposaCreado);
        Invoke ("createMariposa2", 1f);
    }

    void createMariposa2()
    {
        
        Vector3 position = new Vector3(-1, Random.Range(-3f, 0.2f), Random.Range(-10.0f, 10.0f));
        mariposaCreado= Instantiate(mariposa, position, Quaternion.identity);
        Invoke ("destroyMariposa2", 2f);

        
    }

    private void destroyMariposa2()
    {
        Destroy (mariposaCreado);
        Invoke ("createMariposa", 1f);
    }

    void createAbeja()
    {
        
        Vector3 position = new Vector3(-1, Random.Range(-3f, 3f), Random.Range(-10.0f, 10.0f));
        abejaCreado= Instantiate(abejaprefab, position, Quaternion.identity);
        Invoke ("destroyAbeja", 7f);

        
    }

    private void destroyAbeja()
    {
        Destroy (abejaCreado);
        Invoke ("createAbeja", 5f);
    }

}
