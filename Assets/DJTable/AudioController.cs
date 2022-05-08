using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioMixerGroup audiomixergroup;
    
    // Start is called before the first frame update
    void Start()
    {
        audiosource.outputAudioMixerGroup = audiomixergroup;
    }
}
