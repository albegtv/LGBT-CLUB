using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporttolabarotorio : MonoBehaviour
{
	public GameObject spawn;
	int index;
	private void OnTriggerEnter(Collider other)
	{
		Teleport();
	}

	public void alement(int ind, GameObject alement)
	{
		index = ind;
		Instantiate(alement, spawn.transform);
	}

	public void Teleport()
    {
        SceneManager.LoadScene(index);
    }
}
