using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int n_scene = 1;  // индекс загружаемой сцены по умолчанию, который в редакторе можно изменить

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

}
