using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    CharacterController characterController;
	Animator animator;
	public GameObject Keyicon;
	public AudioClip KeySound;
	private AudioSource audioSource;


	void Start () {
		characterController = GetComponent<CharacterController> ();
		animator = GetComponent<Animator> ();

		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	//void Update ()
	void OnCollisionEnter(Collision other) {

		if (other.gameObject.CompareTag("Player")) {
			//Debug.Log ("aaaaaaaaa");

			animator.Play ("open");

			Keyicon.SetActive (false);

			audioSource.PlayOneShot (KeySound);

		}
	}
}


