using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonManager : MonoBehaviour
{
    public SpriteRenderer[] colores;
    public AudioSource[] buttonSounds;

    private int colorSelect;
    public float stayLit;
    private float stayLitCounter;

    public float esperaEntreLuces;
    public float esperaEntreContador;

    private bool debeSerLit;
    private bool debeSerOscuro;

    public List<int> activeSequence;
    private int positionInSequence;
    private int inputInSequence;

    private bool gameActive;

    public AudioSource correct;
    public AudioSource incorrect;

    public Text scoreText;

    public int objetivoNivel;
    public GameObject pantallaExito;
    public GameObject EmpiezaDeNuevo;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", 0);
        }
        scoreText.text = "0" + PlayerPrefs.GetInt("HiScore");

        pantallaExito.gameObject.SetActive(false);
        EmpiezaDeNuevo.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(debeSerLit)
        {
            Debug.Log("debeserLit esta activo");
            stayLitCounter -= Time.deltaTime;
            if(stayLitCounter < 0)
            {
                colores[activeSequence[positionInSequence]].color = new Color(colores[activeSequence[positionInSequence]].color.r, colores[activeSequence[positionInSequence]].color.g, colores[activeSequence[positionInSequence]].color.b, 0.1f);

                buttonSounds[activeSequence[positionInSequence]].Stop();
                debeSerLit = false;
                debeSerOscuro = true;
                esperaEntreContador = esperaEntreLuces;

                positionInSequence++;
            }
        }

        if(debeSerOscuro)
        {
            Debug.Log("debeseroscuro esta activo");
            esperaEntreContador -= Time.deltaTime;

            if (positionInSequence >= activeSequence.Count)
            {
                debeSerOscuro = false;
                gameActive = true;
                Debug.Log("gameActive esta activo");
            }
            else
            {
                if (esperaEntreContador < 0)
                {
                    
                    colores[activeSequence[positionInSequence]].color = new Color(colores[activeSequence[positionInSequence]].color.r, colores[activeSequence[positionInSequence]].color.g, colores[activeSequence[positionInSequence]].color.b, 1f);
                    buttonSounds[activeSequence[positionInSequence]].Play();
                    stayLitCounter = stayLit;
                    debeSerLit = true;
                    debeSerOscuro= false;
                }
            }
        }

        if((activeSequence.Count) - 1 == objetivoNivel)
        {
            pantallaExito.gameObject.SetActive(true); 
            buttonSounds[activeSequence[positionInSequence]].Stop();

            //inputInSequence = 0;//
            
        }          
    }

    public void StartGame()
    {
        activeSequence.Clear();
        EmpiezaDeNuevo.gameObject.SetActive(false);


        positionInSequence = 0;
        inputInSequence = 0;

        colorSelect = Random.Range(0, colores.Length);

        activeSequence.Add(colorSelect);

        colores[activeSequence[positionInSequence]].color = new Color(colores[activeSequence[positionInSequence]].color.r, colores[activeSequence[positionInSequence]].color.g, colores[activeSequence[positionInSequence]].color.b, 1f);
        buttonSounds[activeSequence[positionInSequence]].Play();
        stayLitCounter = stayLit;
        debeSerLit = true;

        scoreText.text = "Score:0 - HighScore:" + PlayerPrefs.GetInt("HiScore");
    }

    public void ColorPresionado(int whichButton)
    {
        if(gameActive)
        {
            if(activeSequence[inputInSequence] == whichButton)
            {
                Debug.Log("Correct");
                
                inputInSequence++;

                if(inputInSequence >= activeSequence.Count)
                {
                    if(activeSequence.Count > PlayerPrefs.GetInt("HiScore"))
                    {
                        PlayerPrefs.SetInt("Hiscore", activeSequence.Count);
                    }
                    scoreText.text = "Score: " + activeSequence.Count + "High Score" + PlayerPrefs.GetInt("HiScore");
                    positionInSequence = 0;
                    inputInSequence = 0;

                    colorSelect = Random.Range(0, colores.Length);
                    activeSequence.Add(colorSelect);
                    colores[activeSequence[positionInSequence]].color = new Color(colores[activeSequence[positionInSequence]].color.r, colores[activeSequence[positionInSequence]].color.g, colores[activeSequence[positionInSequence]].color.b, 1f);
                    buttonSounds[activeSequence[positionInSequence]].Play();
                    stayLitCounter = stayLit;
                    debeSerLit = true;

                    gameActive = false;

                    correct.Play();

                    

                }
            }
            else
            {
                Debug.Log("Wrong");
                incorrect.Play();
                gameActive = false;
                EmpiezaDeNuevo.gameObject.SetActive(true);
            }
        }
    }

    
}
