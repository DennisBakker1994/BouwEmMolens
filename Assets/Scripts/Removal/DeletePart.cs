using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePart : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Windmill")
        {
            source.clip = clip;
            source.Play();

            Destroy(other.gameObject);
        }
    }

}


