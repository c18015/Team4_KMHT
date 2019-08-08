using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	void OnCollisionEnter (Collision other){
		
		Application.LoadLevel ("Crear");
		Debug.Log ("sjagd");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
