using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Scripts : MonoBehaviour
{
    [SerializeField] List<GameObject> AR;
    [SerializeField] List<GameObject> PS;
    public void TriggerAuduo()
    {
        for (int i = 0; i < AR.Count; i++)
        {
            AR[i].SetActive(true);
        }
    }
    public void TriggerPartical()
    {
        for (int i = 0; i < PS.Count; i++)
        {
            PS[i].SetActive(true);
        }
    }
    public void TriggerPA()
    {
        for (int i = 0; i < AR.Count; i++)
        {
            AR[i].SetActive(true);
        }
        for (int i = 0; i < PS.Count; i++)
        {
            PS[i].SetActive(true);
        }
    }
}
