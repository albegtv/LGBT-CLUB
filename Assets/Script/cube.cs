using UnityEngine;

public class cube : MonoBehaviour
{
    [SerializeField] GameObject Gameobject;
    [SerializeField] GameObject trigger;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Gameobject)
        {
            trigger.GetComponent<Scripts>().TriggerPA();
        }
    }
}
