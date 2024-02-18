using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MataMosquitosController : MonoBehaviour
{
    public Text scoreInsectoText;
    private int scoreInsecto;
    private int scoreErrorInsecto;
    public Text scoreErrorInsectoText;
    public int mosquitoLimite;
    public int erroresLimite;
    public GameObject pantallaBienInsecto;
    public GameObject juegoTerminadoInsecto;
    public GameObject selectedObject;
    // Start is called before the first frame update
    void Start()
    {
         scoreInsecto = 0;
         scoreErrorInsecto = erroresLimite;
         pantallaBienInsecto.gameObject.SetActive(false);
         juegoTerminadoInsecto.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
         //if (Input.GetMouseButtonDown(0))
        //{
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hitData = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, 0);

            //RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hitData && Input.GetMouseButtonDown(0))
        {
            selectedObject = hitData.transform.gameObject;
        

            //if (gameObject.tag == ("Mosquito")) 
            //tag == ("Mosquito"))
            {
                

                if (selectedObject.tag == ("Mosquito")) 
                {
                    Destroy(hitData.transform.gameObject);
                    scoreInsecto += 1;
                    scoreInsectoText.text = scoreInsecto.ToString();
                }
                else 
                {
                Destroy(hitData.transform.gameObject);
                scoreErrorInsecto -= 1;
                scoreErrorInsectoText.text = scoreErrorInsecto.ToString();
                }
                
            }
            
            }
            else
            {
                Debug.Log("Nada Alcanzado");
            }

        
        if(scoreInsecto == mosquitoLimite)
        {
            Debug.Log("You win");
            {pantallaBienInsecto.gameObject.SetActive(true); }
             
        }

        if(scoreErrorInsecto == 0)
        {
            Debug.Log("You win");
            {juegoTerminadoInsecto.gameObject.SetActive(true); }
             
        }
    }

    public void PremioBonus()
    {
        Neuro.AddCoins (scoreInsecto);

    }
}
