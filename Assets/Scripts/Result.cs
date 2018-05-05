using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	public string fistTime;
	public string secondTime;
	public GameObject fistTimeUI;
	public GameObject secondTimeUI;

	void Start () {
		fistTimeUI.GetComponent<Text> ().text = "" + LapComplete.timeUserFirst;
		secondTimeUI.GetComponent<Text> ().text = "" + LapComplete.timeUserSecond;
	}
	

}
