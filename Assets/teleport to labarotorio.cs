using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class teleporttolabarotorio : MonoBehaviour
{
	public GameObject spawn;
	public Text infoTable;
	int index;
    public NAlement[] CAL;
	private void OnTriggerEnter(Collider other)
	{
		Teleport();
	}
    private void Start()
    {
		Alement(29);
    }

    public void Alement(int ind)
	{
		foreach (NAlement ele in CAL)
		{
			if (ele.indeex == ind)
			{
				infoTable.text = ele.info;
				index = ele.indeex;
				infoTable.transform.parent.gameObject.SetActive(true);
				Instantiate(ele.al, spawn.transform);
			}
		}
	}

	public void Teleport()
	{
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

