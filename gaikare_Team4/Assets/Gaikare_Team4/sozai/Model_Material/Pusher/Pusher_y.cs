﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher_y : MonoBehaviour {


	Vector3 startPosition;

	public float amplitude;
	public float speed;

	public Timer timer;
	public int MinusTime;


	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Player")

			Debug.Log("dfljo");
		timer.AddMinus (MinusTime);

	}


	// Use this for initialization
	void Start () {

		startPosition = transform.localPosition;

	}

	// Update is called once per frame
	void Update () {

		float y = amplitude * Mathf.Sin (Time.time * speed);

		transform.localPosition = startPosition + new Vector3 (0, y, 0);

	}
}
