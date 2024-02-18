using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuroCrece : MonoBehaviour
{
    public int tier;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTier();
        SetEtapa();
        
    }

    public void UpdateTier()
    {
        tier = Neuro.GetEtapa();

    }

    public void SetEtapa()
    {
        GetComponent<SpriteRenderer>().sprite = ExpManager.expManager.neuroCrecimiento[tier];
    }

    public void Evolve()
    {
        tier++;
        SetEtapa();
    }
}
