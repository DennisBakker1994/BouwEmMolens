using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepM : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        PlayRandomAnimation();
    }
    void PlayRandomAnimation()
    {
        float randomValue = Random.value;
        if (randomValue <= 0.2f)
        {
            // Play animation with 20% chance
            animator.SetFloat("StartEating", 0); // Set parameter to favor first animation
        }
        else
        {
            // Play other animation
            animator.SetFloat("StartEating", 1); // Set parameter to favor second animation
        }
    }
    public void AnimationEnd()
    {
        PlayRandomAnimation();
    }
}
