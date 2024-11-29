using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drip : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject particleSystem;
    private bool particlesEnabled = false;
    void Update()
    {
        Vector3 rotation = targetObject.transform.localEulerAngles;

        if ((rotation.x >= 100 && rotation.x <= 260)||
            (rotation.z >= 100 && rotation.z <= 360))
        {
            particleSystem.SetActive(true);
        }
        else 
        {
            particleSystem.SetActive(false);
        }
        
       
    }
}
