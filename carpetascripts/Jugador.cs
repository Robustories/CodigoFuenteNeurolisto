using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador: MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public float velocidad;
    public float altura;
    public GameObject Recarr;
    public GameObject Recaba;
    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        ConstruirNivel();
        
    }

    public void ConstruirNivel()
    {
        Instantiate(Recarr, new Vector3(10,8), transform.rotation);
        Instantiate(Recaba, new Vector3(10,-8), transform.rotation);

        Instantiate(Recarr, new Vector3(17,6), transform.rotation);
        Instantiate(Recaba, new Vector3(17,-10), transform.rotation);

        Instantiate(Recarr, new Vector3(24,10), transform.rotation);
        Instantiate(Recaba, new Vector3(24,-8), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        cuerpo.velocity = new Vector2(velocidad, cuerpo.velocity.y);
        if(Input.GetMouseButtonDown(0))
        {
            cuerpo.velocity = new Vector2(cuerpo.velocity.x, altura);

        }

        if (transform.position.y > 13 || transform.position.y < -13)
        {
            Reinicio();
        }
        
    }

    public void Reinicio()
    {
        SceneManager.LoadScene("4_11");
    }
    
}
