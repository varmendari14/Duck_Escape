using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundEmitter : MonoBehaviour
{
    public AudioClip audioClip;
    public float timeBetweenSounds;
    public bool isRandom;
    public float percentChance;

    float lastSound;

    private void Start()
    {
        lastSound = Time.time;
    }

    private void Update()
    {
        if (Time.time - lastSound >= timeBetweenSounds)
        {
            if (!isRandom)
            {
                AudioSource.PlayClipAtPoint(audioClip, transform.position);
                lastSound = Time.time;
            } else
            {
                if (Random.value < percentChance / 100)
                {
                    AudioSource.PlayClipAtPoint(audioClip, transform.position);
                    lastSound = Time.time;
                }
            }
            
        }
    }

}
