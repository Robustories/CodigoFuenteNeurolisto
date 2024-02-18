using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Microfono : MonoBehaviour
{
    public AudioSource aud;

    bool isHaveMicroPhone;
    string device;
    public Text text;

    //Debug Text
    public Text clipLength;//La longitud del archivo de audio grabado
    public Text devicePosition;//Ubicación del audio del dispositivo
    public Text audioTime;//Hora de grabar audio
    public Text audioSampleTime;//

    
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        string[] devices = Microphone.devices;

        if (devices.Length > 0)
        {
            isHaveMicroPhone = true;
            device = devices[0];
            text.text = devices[0];
        }
        else
        {
            isHaveMicroPhone = false;
            text.text = "No microfono";
        }
    }


    public void Grabar()
    {
        if (!isHaveMicroPhone) return;

        aud.clip = Microphone.Start(device, true, 10, 10000);
        //aud.Play();
        //aud.timeSamples = Microphone.GetPosition(device);
        //aud.timeSamples = 0;
        Debug.Log("iniciar la grabación");
    }

    //Botón de inicio de reproducción
    public void OnPlay()
    {
        aud.Play();
        //aud.timeSamples = Microphone.GetPosition(device);//Después de configurarlo aquí, se sincronizará casi en tiempo real

        int min;
        int max;
        Microphone.GetDeviceCaps(device, out min,out max);
        aud.timeSamples = 0;
        Debug.Log("Empezar a jugar"+min+" "+max);
    }




    private void Update()
    {
        //clipLength.text = "     clipLength:" + aud.clip.length;
        devicePosition.text = " devicePosition:" + Microphone.GetPosition(device);
        audioTime.text = "      audioTime:" + aud.time;
        audioSampleTime.text = "audioSampleTime:" + aud.timeSamples;

        //Debug.Log("     clipLength:" + aud.clip.length);
        //Debug.Log(" devicePosition:" + Microphone.GetPosition(device));
        //Debug.Log("      audioTime:" + aud.time);
        //Debug.Log("audioSampleTime:" + aud.timeSamples);

        aud.timeSamples = Microphone.GetPosition(device);
    }
    
}