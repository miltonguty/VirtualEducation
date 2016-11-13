using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public string sceneName;

	public void ChangeScene () {
		SceneManager.LoadScene (sceneName);
	}
}
