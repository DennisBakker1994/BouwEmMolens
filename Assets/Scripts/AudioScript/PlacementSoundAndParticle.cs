using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSoundAndParticle : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public ParticleSystem ps;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ter")
        {
            source.clip = clip;
            source.Play();

            ps.Play();
        }
    }
}
