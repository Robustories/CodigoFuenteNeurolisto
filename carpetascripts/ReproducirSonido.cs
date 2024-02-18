using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReproducirSonido : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public AudioSource source {get {return GetComponent<AudioSource> ();}}
    public Button btn {get {return GetComponent<Button> ();}}
    public AudioClip clip;
    // Start is called before the first frame update
    void Awake()
    {

    }
    void Start()
    {
        gameObject.AddComponent<AudioSource> ();

        btn.onClick.AddListener (PlaySound);
        
    }

    void PlaySound()
    {
        StopAllAudio();
        source.PlayOneShot (clip);
        Debug.Log("Sonido suena");
    }

    void StopAllAudio() {
     allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
     foreach( AudioSource audioS in allAudioSources) {
         audioS.Stop();
     }
    }
}
