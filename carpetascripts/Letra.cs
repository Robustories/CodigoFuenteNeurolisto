using UnityEngine;
using UnityEngine.UI;

public class Letra : MonoBehaviour
{
    public RawImage img; // imagen a dibujar

    public float x1, y1; // Entrada: punto 1
    public float x2, y2; // Entrada: punto 2

    void Start ()
    {
        Texture2D t = new Texture2D (400, 300); // Mismo tamaño que RawImage

        float slope = (y2 - y1) / (x2 - x1); // Pendiente

        for (int i = (int)x1; i < x2; i++) {
            int x = i;
            int y = Mathf.RoundToInt (slope * (x - x1) + y1);
            t.SetPixel (x, y, Color.red);
        }

        t.Apply ();

        img.texture = t;
    }
}
