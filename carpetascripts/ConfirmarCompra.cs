using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmarCompra : MonoBehaviour
{
    [SerializeField]
    ListaJuguetes lj;
    [SerializeField]
    ShopManager SM;
    [SerializeField]
    Text texto;
    public int ID;
    public int cantidad;
    public bool compra = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (compra)
        {
            texto.text = "¿Comprar" + " " + lj.baseDatos[ID].Nombre + "por un valor de" + lj.baseDatos[ID].precio + "?";
        }
        
    }

    public void Aceptar()
    {
        if (compra)
        {
            SM.ComprarItem(ID);
        }
        this.gameObject.SetActive(false);
    }

    public void Cancelar()
    {
        this.gameObject.SetActive(false);
        print("Compra cancelada");
    }
}
