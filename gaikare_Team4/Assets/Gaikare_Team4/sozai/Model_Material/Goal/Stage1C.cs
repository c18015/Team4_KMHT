using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1C : MonoBehaviour {

	void OnCollisionEnter (Collision other){

		Application.LoadLevel ("Stage1Crear");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
