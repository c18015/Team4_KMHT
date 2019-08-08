using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSE : MonoBehaviour {
	
	public AudioClip TMSound;
	private AudioSource clocksound;

	public float timer = 1.0f;


	void Start () {

		clocksound = gameObject.GetComponent<AudioSource> ();

	}

	// Update is called once per frame
	void OnCollisionEnter(Collision other) {

			
		if (other.gameObject.CompareTag("Player")) {
			
			clocksound.PlayOneShot (TMSound);

				Destroy (this.gameObject, timer);


		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
