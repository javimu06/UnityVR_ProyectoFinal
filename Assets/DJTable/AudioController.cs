using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioMixerGroup audiomixergroup;

    [SerializeField]
    bool shuffle;
    public void changeShuffle() { audiosource.Stop(); shuffle = !shuffle; }

    public List<AudioClip> audioClips;


    // Start is called before the first frame update
    void Start()
    {
        audiosource.outputAudioMixerGroup = audiomixergroup;
        shuffle = true;
    }

    private void Update()
    {
        if (shuffle)
        {
            if (!audiosource.isPlaying)
            {
                int r = Random.Range(0, audioClips.Count);
                AudioClip clip = audioClips[r];
                audiosource.clip = clip;
                audiosource.PlayOneShot(clip);
            }
        }
    }
}
