using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("drop")) 
        {
            // Выключаем коллайдер и рендерер объекта
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;

            // Включаем анимацию
            anim.SetTrigger("TriggerAnimation");
        }
    }
}
