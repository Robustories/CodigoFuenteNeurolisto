using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ListaItemTienda", menuName = "Inventario/Lista", order = 1)]
public class ListaJuguetes : ScriptableObject
{

    [System.Serializable]
    public struct ObjetoInventario
    {
        public string Nombre;
        public int ID;
        public Sprite icono;
        public int precio;
        public Clase clase;
        public Tipo tipo;
        public bool acumulable;
        public string descripcion;
        public string Void;
        public bool isPurshased;

    }

    public enum Clase
    {
        ropa,
        pelota
    }

    public enum Tipo
    {
        ropa,
        pelota
    }

    public ObjetoInventario[] baseDatos;

    public int JuguetesCount
    {
        get{ return baseDatos.Length;}
    }

    public ObjetoInventario GetJuguetes (int index)
    {
       return baseDatos [index];

    }

    public void PurchaseJuguete(int index)
    {
        baseDatos [index].isPurshased = true;

    }


}
