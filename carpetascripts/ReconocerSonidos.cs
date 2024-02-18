using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReconocerSonidos : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public AudioSource source {get {return GetComponent<AudioSource> ();}}
    public AudioClip clip1, clip2, clip3, clip4, clip5, clip6, clip7, clip8, clip9, clip10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlaySound1()
    {
        StopAllAudio();
        source.PlayOneShot (clip1);
        Debug.Log("Sonido reproducido");
        
    }

    public void PlaySound2()
    {
        StopAllAudio();
        source.PlayOneShot (clip2);
        
    }

    public void PlaySound3()
    {
        StopAllAudio();
        source.PlayOneShot (clip3);
        
    }

    public void PlaySound4()
    {
        StopAllAudio();
        source.PlayOneShot (clip4);
    }

    public void PlaySound5()
    {
        StopAllAudio();
        source.PlayOneShot (clip5);
    }

    public void PlaySound6()
    {
        StopAllAudio();
        source.PlayOneShot (clip6);
    }

    public void PlaySound7()
    {
        StopAllAudio();
        source.PlayOneShot (clip7);
    }

    public void PlaySound8()
    {
        StopAllAudio();
        source.PlayOneShot (clip8);
    }

    public void PlaySound9()
    {
        StopAllAudio();
        source.PlayOneShot (clip9);
    }

    public void PlaySound10()
    {
        StopAllAudio();
        source.PlayOneShot (clip10);
    }

    void StopAllAudio() {
     allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
     foreach( AudioSource audioS in allAudioSources) {
         audioS.Stop();
     }
    }
}
