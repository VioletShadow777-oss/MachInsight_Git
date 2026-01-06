using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISound : MonoBehaviour
{
    [SerializeField] private AudioClip clickClip;
    [SerializeField] private AudioClip otherClip;

    private AudioSource clickSource;

    private void Start()
    {
        clickSource = GetComponent<AudioSource>();
    }
    public void Play_Sound_Click()
    {
        clickSource.PlayOneShot(clickClip);
    }
    public void Play_Sound_Other()
    {
        clickSource.PlayOneShot(otherClip);
    }
}
