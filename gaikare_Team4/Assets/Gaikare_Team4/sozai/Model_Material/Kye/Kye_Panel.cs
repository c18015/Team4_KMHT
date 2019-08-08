using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kye_Panel : MonoBehaviour {

	public GameObject Keyicon;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Keyicon.SetActive (true);

		}

		if (Input.GetKey (KeyCode.Space)) {

			Keyicon.SetActive (false);
		}








		/*Keyicon.SetActive (false);

		if (Input.GetButtonDown ("Fire1"))
			Keyicon.SetActive (true);*/



		
	}
}
