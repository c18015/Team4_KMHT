using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SundoTest : MonoBehaviour {

	AudioSource gameBGM;

	float count = 0;



	void Start () {

		gameBGM = GetComponent<AudioSource> ();

		//gameBGM.Play ();
		//gameBGM.Stop ();
		
	}


	void Update () {
		count += Time.deltaTime;

		if (Input.GetButtonDown ("Fire1")) {
			BGMaa ();
		}
	}

	void BGMaa (){
		gameBGM.Play ();
	}
}
