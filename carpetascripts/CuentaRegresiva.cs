using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaRegresiva : MonoBehaviour
{
    public float ConteoRegresivo = 0;
    public string InfoString = "Escriba aquí ";
    public Text TextoCompleto;
    public Reloj relojt;

    // Start is called before the first frame update
    void Start()
    {
        Reloj variable = GetComponent<Reloj>();
    }

    // Update is called once per frame
    void Update()
    {
        ConteoRegresivo = relojt.tiempoAMostrarEnSegundos;
        if(TextoCompleto != null)
        {
            TextoCompleto.text = InfoString + ConteoRegresivo.ToString();
        }
        
    }
}
