using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    [SerializeField] GameObject Spawn;
    [SerializeField] GameObject TextG;
    [SerializeField] int indexScene;
    [SerializeField] List<Alements> AlementsList;
    public void Button(int index)
    {
        for (int i = 0; i < AlementsList.Count; i++)
        {
            if(i == index)
            {
                foreach(Transform t in Spawn.transform)
                {
                    Destroy(t);
                }
                Instantiate(AlementsList[i].Alement, Spawn.transform);
                TextG.transform.parent.gameObject.SetActive(true);
                TextG.GetComponent<Text>().text = AlementsList[i].Text;
                indexScene = AlementsList[i].SceneIndex;
                break;
            }
        }
    }
    public void Teleport()
    {
        SceneManager.LoadScene(indexScene);
    }
}
[System.Serializable]
public class Alements
{
    [SerializeField] public GameObject Alement;
    [SerializeField] public int SceneIndex;
    [SerializeField] public string Text;
}
