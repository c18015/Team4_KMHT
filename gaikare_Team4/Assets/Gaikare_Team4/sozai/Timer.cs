using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float countTime;

	void Start () {
	}

	void Update () {

		countTime -= Time.deltaTime;


		if (countTime < 0)
			countTime = 0;

		GetComponent<Text> ().text = "残り時間:" + countTime.ToString ("F0");


		if (countTime == 0) {
			Application.LoadLevel ("GameOvre");
		}

	}

	public void AddTimer (int amount){
		countTime += amount;
	}
	public void AddMinus (int amount){
		countTime -= amount;
	}
}
	