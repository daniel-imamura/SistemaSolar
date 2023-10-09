using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAudio : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        audioSource.enabled = true;
    }    
    void OnMouseUp()
    {
        audioSource.enabled=false;
    }
}
