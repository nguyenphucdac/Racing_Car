using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

	public string MinCount;
	public string SecCount;
	public int MilliCount;

	public GameObject MinDisplay;
	public GameObject SecDisplay;
	public GameObject MilliDisplay;

	void Start () {
		MinCount = "0" + PlayerPrefs.GetInt ("MinSave");

		if (PlayerPrefs.GetInt ("SecSave") < 10) {
			SecCount = "0" + PlayerPrefs.GetInt ("SecSave");
		} else {
			SecCount ="" + PlayerPrefs.GetInt ("SecSave");
		}

		MilliCount =(int) PlayerPrefs.GetFloat ("MilliSave");

		MinDisplay.GetComponent<Text> ().text = "" + MinCount + ":";
		SecDisplay.GetComponent<Text> ().text = "" + SecCount + ".";
		MilliDisplay.GetComponent<Text> ().text = "" + MilliCount;
	}

}
