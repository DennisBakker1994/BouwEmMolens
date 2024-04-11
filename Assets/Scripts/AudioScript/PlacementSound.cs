using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        source.clip = clip;
        source.Play();
    }
}
