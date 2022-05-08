using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Valve.VR.InteractionSystem
{
    public class DjPotenciometro : MonoBehaviour
    {
        public AudioMixer djMixer;
        public AudioSource AudioSource;
        public string exposedParameter;
        public float amplitude;
        public int initVal;
        // Start is called before the first frame update

        void Update()
        {
            float currentParam;
            djMixer.GetFloat(exposedParameter, out currentParam);

            currentParam = AudioSource.volume * gameObject.GetComponent<CircularDrive>().outAngle / 360.0f * amplitude + initVal;
            djMixer.SetFloat(exposedParameter, currentParam);
        }
    }
}
