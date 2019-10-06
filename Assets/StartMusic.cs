using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    public AudioClip overworldAudio;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(overworldAudio, transform.position);
    }
}
