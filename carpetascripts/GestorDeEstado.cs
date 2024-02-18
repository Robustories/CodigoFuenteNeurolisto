using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorDeEstado : MonoBehaviour
{
    public static void Guardar(MonoBehaviour componente)
    {
        Estado estado = componente as Estado;
        PlayerPrefs.SetInt("Nivel", estado.Nivel);
        PlayerPrefs.SetInt("Vidas", estado.Vidas);
        PlayerPrefs.SetString("slot", JsonUtility.ToJson(componente));

    }

    public static void Cargar(MonoBehaviour componente)
    {
        Estado estado = componente as Estado;
        estado.Nivel = PlayerPrefs.GetInt("Nivel");
        estado.Vidas = PlayerPrefs.GetInt("Vidas");
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("slot"), componente);

    }

}
