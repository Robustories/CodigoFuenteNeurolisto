using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoInsecto : MonoBehaviour
{
    public float Speed;
    public float LivingTime = 6f;
    private Rigidbody2D Rigidbody2D;
    public Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, LivingTime);
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }
}
