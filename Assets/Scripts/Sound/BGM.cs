using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip _bgm;
    public AudioSource _audioSource;
    // Start is called before the first frame update

    private void Awake()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
        _audioSource.clip = _bgm;
        _audioSource.volume = 0.1f;
        _audioSource.Play();
    }
}
