using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.pitch = 0.5f;
        audioSource.volume= 0.1f;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
