using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class teleporttolabarotorio : MonoBehaviour
{
	public GameObject spawn;
	public Text infoTable;
	int index;
	private void OnTriggerEnter(Collider other)
	{
		Teleport();
	}

	public void Alement(int ind, GameObject alement, string info)
	{
		infoTable.text = info;
		index = ind;
		Instantiate(alement, spawn.transform);
	}

	public void Teleport()
    {
        SceneManager.LoadScene(index);
    }
	
	public void OnInfo(bool b)
	{
		b = !b;
		infoTable.gameObject.SetActive(b);
	}
}
