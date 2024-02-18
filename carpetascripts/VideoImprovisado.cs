using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoImprovisado : MonoBehaviour
{
    public Sprite[] ImagenesAMostrar;
    public float[] tiemposIniciai, tiemposFinali;
    public float tiempoTranscurridoi;
    public bool videoEmpezado, subtituloActivoi, esperandoSiguienteFrasei;
    public int indiceRequeridoi, ipuntos, indiceClicki;
    private int indiceActuali;
    // Start is called before the first frame update
    void Start()
    {
        EmpezarVideo();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (videoEmpezado)
        {
            tiempoTranscurridoi += Time.deltaTime;

        }

        AlgoritmoSubtitulosv();
        
    }

    public void EmpezarVideo()
    {
        //Depende de cuando y donde le des play al audiosource, se puede llamar desde otros scripts
        tiempoTranscurridoi = 0f;
        indiceActuali = 0;
        indiceClicki = 0;
        videoEmpezado = true;
        subtituloActivoi = false;
    }

    void AlgoritmoSubtitulosv()
    {
        if (!subtituloActivoi)
        {
            if (tiempoTranscurridoi >= tiemposIniciai[indiceActuali])
            {
                subtituloActivoi = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = ImagenesAMostrar [indiceActuali];
            }

        }
        else
        {
            if (tiempoTranscurridoi >= tiemposFinali[indiceActuali])
            {
                subtituloActivoi = false;
                indiceActuali++;
                if (indiceActuali < ImagenesAMostrar.Length && indiceActuali<tiemposIniciai.Length && indiceActuali < tiemposFinali.Length )
                {
                    subtituloActivoi = false;
                }
                else
                {
                        videoEmpezado = false;
                    //cancion finalizada?
                }

            }


        }

    }


}
