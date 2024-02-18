using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silenciar : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public AudioSource source {get {return GetComponent<AudioSource> ();}}
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach( AudioSource audioS in allAudioSources) {
        audioS.Stop();}

        Invoke ("Empezar", 0.1f);
        
        
    }


    void Empezar()
    {
        source.PlayOneShot (clip);
        
    }
}
