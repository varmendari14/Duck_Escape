using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class HumanAudioScript : MonoBehaviour
{
    public AudioClip jumpAudio;
    public AudioClip swingAudio;
    public AudioClip runAudio;
    public AudioClip sneakAudio;
    public AudioClip walkAudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayJumpAudio()
    {
        AudioSource.PlayClipAtPoint(jumpAudio, transform.position);
    }

    void PlayNetAudio()
    {
        AudioSource.PlayClipAtPoint(swingAudio, transform.position);
    }

    void PlayRunAudio()
    {
        AudioSource.PlayClipAtPoint(runAudio, transform.position);
    }
    
    void PlaySneakAudio() {
        AudioSource.PlayClipAtPoint(sneakAudio, transform.position);
    }
    void PlayWalkAudio() {
        AudioSource.PlayClipAtPoint(walkAudio, transform.position);
    }
}
