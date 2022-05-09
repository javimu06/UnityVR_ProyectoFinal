using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DjButton : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioMixer djMixer;
    public AudioClip song;
    public float volume;
    public string triggerName;

    public AnimatorManager animatormanager;

    // Start is called before the first frame update
    public void DJputtonDown()
    {
        StartCoroutine(FadeMixerGroup.StartFade(djMixer, "VolumeParam", 1, 0));
        Invoke("playAudioSeconds", 1);
        StartCoroutine(FadeMixerGroup.StartFade(djMixer, "VolumeParam", 1, volume));
    }
    void playAudioSeconds()
    {
        audiosource.Stop();
        audiosource.PlayOneShot(song, volume);
        animatormanager.playingAnim(triggerName);
    }
}
