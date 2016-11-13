using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ValidateQuestion : MonoBehaviour {

	public bool isCorrect;
	//public GameObject checkMarkImage;
	//public GameObject xMarkImage;
	public GameObject correct;
	public GameObject incorrect;

	void Start() 
	{
		Debug.Log ("Start validate "+isCorrect);
		//correct = GameObject.Find ("GoodText").GetComponent<Text>();
		//incorrect = GameObject.Find ("BadText").GetComponent<Text>();
	}

	public void Validate() 
	{
		Debug.Log ("Validate Question " + isCorrect);
		if (isCorrect) {
			correct.SetActive (true);
			incorrect.SetActive (false);
		} else {
			correct.SetActive (false);
			incorrect.SetActive (true);
		}
	}
}
