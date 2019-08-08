using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockItem : MonoBehaviour {

	public Timer timer;
	public int plasTime;

	void Start () {

	}


	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")
			//Debug.Log ("dfljo");
		    timer.AddTimer (plasTime);
		
		
		    Destroy (this.gameObject);



	}


	// Use this for initialization

	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);
	}
}
		