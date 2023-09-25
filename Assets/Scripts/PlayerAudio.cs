using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField] private AudioClip _jumpSound, _switchSound, _bumpSound;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        _audioSource.PlayOneShot(_jumpSound);
    }

    public void PlaySwitch()
    {
        _audioSource.PlayOneShot(_switchSound);
    }

    public void PlayBump()
    {
        AudioSource.PlayClipAtPoint(_bumpSound, Camera.main.transform.position);
    }
}
