using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contacto : MonoBehaviour
{
    void OnCollisionEnter(Collision otherObj) {
    if (otherObj.gameObject.tag == "Canasta") {
        Destroy(gameObject, .1f);
    }
}
}
