﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HaftLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;
	public GameObject LapCounter;
	public int LapsDone;

	public static string timeUserFirst;
	public static string timeUserSecond;

	public float RawTime;
	public GameObject RaceFinish;

	void Update(){
		if (LapsDone == 1) {
			//RaceFinish.SetActive (true);
			//SceneManager.LoadScene (3);
		}
	}

	void OnTriggerEnter(){

		LapsDone += 1;
		if (LapsDone == 1) {
			RaceFinish.SetActive (true);
		}

		RawTime = PlayerPrefs.GetFloat ("RawTime");
		if (LapTimeManager.RawTime < RawTime) {

			if (LapTimeManager.SecondCount <= 9) {
				SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecondCount + ".";
			} else {
				SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecondCount + ".";
			}

			if (LapTimeManager.MinuteCount <= 9) {
				MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteCount + ".";
			} else {
				MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteCount + ".";
			}

			MilliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MilliCount;
		
		PlayerPrefs.SetInt ("MinSave", LapTimeManager.MinuteCount);
		PlayerPrefs.SetInt ("SecSave", LapTimeManager.SecondCount);
		PlayerPrefs.SetFloat ("MilliSave", LapTimeManager.MilliCount);
		PlayerPrefs.SetFloat ("RawTime", LapTimeManager.RawTime);

		}

		if (LapTimeManager.MinuteCount < 10) {
			timeUserFirst = "0" + LapTimeManager.MinuteCount + ":";
		} else {
			timeUserFirst = "" + LapTimeManager.MinuteCount + ":";
		}
		if (LapTimeManager.SecondCount < 10) {
			timeUserFirst += "0" + LapTimeManager.SecondCount + ".";
		} else {
			timeUserFirst += "" + LapTimeManager.SecondCount + ".";
		}

		timeUserFirst += LapTimeManager.MilliCount.ToString("F0");

		if (LapTimeManager.MinuteCount < 10) {
			timeUserSecond = "0" + LapTimeManager.MinuteCount + ":";
		} else {
			timeUserSecond = "" + LapTimeManager.MinuteCount + ":";
		}

		if (LapTimeManager.SecondCount + 3 < 10) {
			timeUserSecond += "0" + (LapTimeManager.SecondCount + 3) + ".";
		} 
		else if (LapTimeManager.SecondCount + 3 > 60) {
			timeUserSecond = "" + (LapTimeManager.MinuteCount + 1) + ".";

			timeUserSecond += "0" + (LapTimeManager.SecondCount + 3 - 60) + ".";
		} 
		else {
			timeUserSecond += "" + (LapTimeManager.SecondCount + 3) + ".";
		}
			
		timeUserSecond += "7";

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.RawTime = 0;

		//LapCounter.GetComponent<Text>().text = "" + LapsDone; 

		HaftLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);


	}
}
