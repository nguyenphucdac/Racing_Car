using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewMode;
	public GameObject LevelMusic;
	public GameObject CompleteTrigger;
	public AudioSource FinishMusic;

	public float timeWait = 7;

	void Update(){
		this.GetComponent<BoxCollider> ().enabled = true;
		timeWait -= Time.deltaTime;
		if(timeWait <= 0){
			SceneManager.LoadScene (3);
		}
	}

	void Start () {
		CompleteTrigger.SetActive (false);
		FinishCam.SetActive (true);
	}

}
