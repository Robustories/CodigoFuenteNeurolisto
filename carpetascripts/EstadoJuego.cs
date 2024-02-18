using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego : MonoBehaviour
{
    public static EstadoJuego  estadoJuego;

    private String rutaArchivo;

    void Awake()
    {
        rutaArchivo = Application.persistentDataPath;
        if (estadoJuego == null)
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (estadoJuego != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        //FileStream file = new FileStream(rutaArchivo);

        DatosAGuardar datos = new DatosAGuardar();

        //bf.Serialize(file, datos);

        //file.Close();

    }

    void Cargar()
    {
        BinaryFormatter bf = new BinaryFormatter();

    }
}

[Serializable]

class DatosAGuardar
{
    public DatosAGuardar()
    {

    }
}
