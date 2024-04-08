using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAnimation : MonoBehaviour
{
    public Animator animator;
    public float chanceOfAnimationB = 0.2f;

    void Start()
    {
        PlayRandomAnimation();
    }

    void PlayRandomAnimation()
    {
        float randomValue = Random.value;
        if (randomValue <= chanceOfAnimationB)
        {
            animator.Play("Eating Grass");
        }
        else
        {
            animator.Play("Idle");
        }
    }

    // This function will be called when any animation finishes
    void OnAnimationFinish()
    {
        // Play another animation when the current one finishes
        PlayRandomAnimation();
    }
}
