using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaEscena : MonoBehaviour
{
    public GameObject pantalla_gameOver;
    // Start is called before the first frame update
    void Start()
    {
        pantalla_gameOver.gameObject.SetActive(false);
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Flecha")
        {
            pantalla_gameOver.gameObject.SetActive(true);
        }
    }
}
