using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject x;
    public GameObject part;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchObject")) 
        {
            part.SetActive(true);
            Disappear();
        }
        
    }
    void Disappear()
    {
        x.SetActive(false);
    }
}

