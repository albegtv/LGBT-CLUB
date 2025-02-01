using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class teleporttolabarotorio : MonoBehaviour
{
	public GameObject spawn;
	public Text infoTable;
	public int index;
	public NAlement[] SA;

	public void Alement(int ind)
	{
		foreach (NAlement i in SA)
		{
			if (ind == i.indeex)
			{
				infoTable.transform.parent.gameObject.SetActive(true);
				infoTable.text = i.info;
				index = ind;
				Instantiate(i.al, spawn.transform);
			}
		}
	}

	public void Teleport()
	{
		if (index != 0)
		{
			Debug.Log(index);
			SceneManager.LoadScene(index);
		}
	}
	[System.Serializable]
	public class NAlement
	{
		public int indeex;
		public string info;
		public GameObject al;
	}
}
