using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PantallaCarga : MonoBehaviour
{
    public GameObject ui_carga;
    public Image ui_barra;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Carga1()
    {
        StartCoroutine("Cargar1");
    }

    public IEnumerator Cargar1()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 1");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga2()
    {
        StartCoroutine("Cargar2");
    }

    public IEnumerator Cargar2()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 2");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga3()
    {
        StartCoroutine("Cargar3");
    }

    public IEnumerator Cargar3()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 3");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga4()
    {
        StartCoroutine("Cargar4");
    }

    public IEnumerator Cargar4()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 4");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga5()
    {
        StartCoroutine("Cargar5");
    }

    public IEnumerator Cargar5()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 5");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga6()
    {
        StartCoroutine("Cargar6");
    }

    public IEnumerator Cargar6()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 6");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga7()
    {
        StartCoroutine("Cargar7");
    }

    public IEnumerator Cargar7()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 7");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Carga8()
    {
        StartCoroutine("Cargar8");
    }

    public IEnumerator Cargar8()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Tema 8");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Menu1()
    {
        StartCoroutine("CargarMenu1");
    }

    public IEnumerator CargarMenu1()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Menu 1");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }

    public void Menu2()
    {
        StartCoroutine("CargarMenu2");
    }

    public IEnumerator CargarMenu2()
    {
        ui_carga.SetActive(true);
        AsyncOperation micarga = SceneManager.LoadSceneAsync("Menu 2");
        while(!micarga.isDone)
        {
            ui_barra.fillAmount = micarga.progress;
            yield return null;
        }
    }
}
