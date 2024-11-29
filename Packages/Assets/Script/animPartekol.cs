using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPartekol : MonoBehaviour
{

    public ParticleSystem particleSystem;
    public Animator animator;

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject)
        {
            particleSystem.Play();
            animator.SetTrigger("ActivateAnimation");
        }
        
    }
   
} 
