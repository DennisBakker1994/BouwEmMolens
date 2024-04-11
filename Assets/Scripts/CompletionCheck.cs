using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletionCheck : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    public Animator animator;

    public void CheckForCompletion()
    {
        if (GetComponentInChildren<SnapManager>().windmillCompleted == true)
        {
            Debug.Log("1");
            source.clip = clip;
            source.Play();

            animator.Play("New State 0");


        }
    }
}
