using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	public GameObject barriar;
	public GameObject Keyicon;


	void Start () {

	}
		


	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
			Destroy (this.gameObject);

		if (other.gameObject.tag == "Player")
			Destroy (barriar);

		if (other.gameObject.tag == "Player")
			Keyicon.SetActive (true);


		

		
	}

}



	/* Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
*/