using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour {

	public void Home () {
		SceneManager.LoadScene ("Menu");
	}
}
