using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPartekol : MonoBehaviour
{
    public GameObject NgameObject;
    public ParticleSystem NparticleSystem;
    public Animator animator;
    public string trigger;
    private void Start()
    {
        NparticleSystem.Pause();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("g");
        if (other.gameObject == NgameObject)
        {
            NparticleSystem.Play();
            animator.SetTrigger(trigger);
        }
    }
} 
