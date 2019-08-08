using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyiconDes : MonoBehaviour {

	public GameObject Keyicon;

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
			Destroy (this.gameObject);

		Keyicon.SetActive (false);

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
