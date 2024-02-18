using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararSonido : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public AudioSource source {get {return GetComponent<AudioSource> ();}}
    public AudioClip clip;
    // Start is called before the first frame update
    void Awake()
    {
        StopAllAudio();

    }
    void Start()
    {
        source.Play();
    }

    void StopAllAudio() {
     allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
     foreach( AudioSource audioS in allAudioSources) {
         audioS.Stop();
     }
    }
}
