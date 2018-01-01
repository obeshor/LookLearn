using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    public GameObject photo;
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

    

    public void popupAudio()
    {
        photo.SetActive(true);
        _audio_source.Play();
    }

    public void closeAudio()
    {
        photo.SetActive(false);
        _audio_source.Stop();
    }

   
}
