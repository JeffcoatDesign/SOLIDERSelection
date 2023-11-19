using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioDescription : MonoBehaviour
{
    private AudioSource _audioSource;
    bool _isPlaying = false;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void Play()
    {
        if (!_isPlaying)
        {
            _audioSource.Play();
            _isPlaying = true;
        }
    }

    public void Stop () 
    { 
        _audioSource.Stop(); 
        _isPlaying = false;
    }
}
