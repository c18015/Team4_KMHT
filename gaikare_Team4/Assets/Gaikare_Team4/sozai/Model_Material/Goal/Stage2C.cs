using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2C : MonoBehaviour {

	void OnCollisionEnter (Collision other){

		Application.LoadLevel ("Stage2Crear");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
