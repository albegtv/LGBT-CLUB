using UnityEngine;

public class PS : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.gameObject);
        if (other.name == "Glass")
        {
            other.GetComponent<feyl>().Coll();
        }
    }
}
