using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceExample : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void OnMouseUp()
    {
       m_Rigidbody.AddForce(transform.up * m_Thrust);
    }

    
}
