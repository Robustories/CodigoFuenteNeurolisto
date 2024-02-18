using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExpManager : MonoBehaviour
{
    public static ExpManager expManager;
    public GameObject Prefab;
    public GameObject[] pantallaEventos;
    public GameObject evento0, evento1, evento2, evento3, evento4, evento5, evento6, evento7, evento8;
    public GameObject botonDesbloqueable, NeuroDesbloqueable;
    public Sprite[] neuroCrecimiento;
    public int etapaA;
    public int requisitoA;

    [SerializeField] TMP_Text[] coinsUIText;
    // Start is called before the first frame update
    void Awake()
    {
        expManager = this;
        evento0.gameObject.SetActive(false);
        evento1.gameObject.SetActive(false);
        evento2.gameObject.SetActive(false);
        evento3.gameObject.SetActive(false);
        evento4.gameObject.SetActive(false);
        evento5.gameObject.SetActive(false);
        evento6.gameObject.SetActive(false);
        evento7.gameObject.SetActive(false);
        evento8.gameObject.SetActive(false);
        botonDesbloqueable.gameObject.SetActive(false);
        NeuroDesbloqueable.gameObject.SetActive(false);


    }

    void Start()
    {
        UpdateExpUIText();
        UpdateExpTotal();
        MostrarEvento();
        //pantallaEventos[].SetActive(false)

    }

    public void UpdateExpUIText()
    {
        etapaA = Neuro.GetEtapa();

        for (int i = 0; i < coinsUIText.Length; i++)
        {
            SetExpText(coinsUIText[i], Neuro.GetExpTotal());
        }
    }

    void SetExpText (TMP_Text textMesh, int value)
    {
        if (value >= 1000)
        textMesh.text = string.Format ("{0}K.{1}", (value/1000), GetFirstDigitFromNumber(value % 1000));
        else
        textMesh.text = value.ToString();
    }

    int GetFirstDigitFromNumber(int num)
    {
        return int.Parse (num.ToString() [0].ToString());
    }

    public void UpdateExpTotal()
    {
        requisitoA = Neuro.GetExpTotal();
    }

    public void MostrarEvento()
    {
        if (requisitoA == 0)
        {
            evento0.gameObject.SetActive(true);

        }

        if (requisitoA >= 1 && requisitoA <= 100)
        {
            evento1.gameObject.SetActive(true);

        }

        if (requisitoA >= 101 && requisitoA <= 200)
        {
            evento2.gameObject.SetActive(true);

        }

        if (requisitoA >= 201 && requisitoA <= 300)
        {
            evento3.gameObject.SetActive(true);

        }

        if (requisitoA >= 201 && requisitoA <= 300)
        {
            evento3.gameObject.SetActive(true);

        }

        if (requisitoA >= 301 && requisitoA <= 400)
        {
            evento4.gameObject.SetActive(true);

        }

        if (requisitoA >= 401 && requisitoA <= 500)
        {
            evento5.gameObject.SetActive(true);

        }

        if (requisitoA >= 501 && requisitoA <= 600)
        {
            evento6.gameObject.SetActive(true);

        }

        if (requisitoA >= 601 && requisitoA <= 700)
        {
            evento7.gameObject.SetActive(true);

        }

        if (requisitoA >= 301)
        {
            evento8.gameObject.SetActive(true);
            NeuroDesbloqueable.gameObject.SetActive(true);
            botonDesbloqueable.gameObject.SetActive(true);

        }

        


    }
}
