using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOthers : MonoBehaviour {

    private AudioSource _audio_source;

    // Use this for initialization
    void Start()
    {
        _audio_source = gameObject.GetComponent<AudioSource>();

        _audio_source.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void listenAudio()
    {
  
        _audio_source.Play();
    }

   
}
