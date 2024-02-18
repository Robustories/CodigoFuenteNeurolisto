using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleSpawner : MonoBehaviour
{
    public GameObject molePrefab;
    public GameObject molePrefab2;
    public Transform[] spawnPoints;
    float ciclo = 3;
    
    public Text gameText;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, ciclo);
        InvokeRepeating("SpawnOtro", 2f, ciclo);
    }

    public void Spawn()
    {
        GameObject mole = Instantiate(molePrefab) as GameObject;
        mole.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;

    }

    public void SpawnOtro()
    {
        GameObject mole = Instantiate(molePrefab2) as GameObject;
        mole.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;

    }

    
}
