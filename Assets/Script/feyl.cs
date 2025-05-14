using UnityEngine;
using System.Collections;


public class feyl : MonoBehaviour
{
    [Range(0, 1)]
    public float StartFillWithMaterial;
    [Range(0,1)]
    public float fillWithMaterial;
    public Material feylPrefab;
    public void Coll()
    {
        if(feylPrefab.GetFloat("_fill")<= fillWithMaterial)
        feylPrefab.SetFloat("_fill", feylPrefab.GetFloat("_fill")+0.0025f);
    }
    private void Start()
    {
        feylPrefab.SetFloat("_fill", StartFillWithMaterial);
    }
}
