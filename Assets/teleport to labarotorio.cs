using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teleporttolabarotorio : MonoBehaviour
{
	public GameObject spawn;
	public Text infoTable;
	public int index;
	public NAlement[] SA;
    private void OnTriggerEnter(Collider other)
    {
		Teleport();
    }

    public void Alement(int ind)
	{
		foreach (NAlement i in SA)
		{
			if (ind == i.indeexAl)
			{
				infoTable.transform.parent.gameObject.SetActive(true);
				infoTable.text = i.info;
				index = i.indeex;
				Instantiate(i.al, spawn.transform);
			}
		}
	}

    public void Teleport()
	{
		if (index != 0)
		{
			SceneManager.LoadScene(index);
		}
	}
}
[System.Serializable]
public class NAlement
{
    public int indeexAl;
    public int indeex;
    public string info;
    public GameObject al;
}
