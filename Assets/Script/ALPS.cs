using UnityEngine;

public class ALPS : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.name == "china dish")
        {
            other.GetComponent<Scripts>().TriggerPartical();
        }
    }
}
