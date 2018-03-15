using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaftPointTrigger : MonoBehaviour {
	public GameObject LapCompleteTrigger;
	public GameObject HaftLapTrigger;

	void OnTriggerEnter(){
		LapCompleteTrigger.SetActive (true);
		HaftLapTrigger.SetActive (false);
	}


}
