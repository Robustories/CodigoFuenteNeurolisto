using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontriggerdestroy : MonoBehaviour
{
    void OntriggerEnter (Collider other)
    {
        Destroy(other.gameObject);
    }
}
