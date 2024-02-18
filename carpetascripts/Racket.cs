using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 100.0f;
    // Start is called before the first frame update
    private void fixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontalInput * speed;

    }

}
