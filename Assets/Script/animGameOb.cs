using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animGameOb : MonoBehaviour
{
    public Animator animator; // ссылка на компонент аниматора

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TouchObject")) // проверяем, что объект, с которым столкнулись, имеет тэг "TouchObject"
        {
            animator.SetTrigger("TriggerName"); // включаем анимацию по имени триггера
        }
    }
}
