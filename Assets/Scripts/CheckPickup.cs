using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPickup : MonoBehaviour
{
    public AudioClip catchAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision other) {
        //Debug.Log("collided");
        if (other.gameObject.tag == "pickup" || other.gameObject.tag == "ugly" 
            || other.gameObject.tag == "rubber") {
                other.gameObject.SetActive(false);
                AudioSource.PlayClipAtPoint(catchAudio, transform.position);
        }
    }
}
