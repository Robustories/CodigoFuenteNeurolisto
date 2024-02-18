using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public AudioSource source {get {return GetComponent<AudioSource> ();}}
    public AudioClip clip;
    private Rigidbody2D Rigidbody2D;
    BoxCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        
        coll = GetComponent<BoxCollider2D>();
        
    }


    void OnMouseUp()
    {
        {
        StopAllAudio();
        source.PlayOneShot (clip);
        Debug.Log("Sonido suena");
        }
    }

    void StopAllAudio() {
     allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
     foreach( AudioSource audioS in allAudioSources) {
         audioS.Stop();
     }
    }
}
