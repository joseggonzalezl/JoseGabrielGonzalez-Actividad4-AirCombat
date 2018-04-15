using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (0.0f, 0.0f, 2.0f);
	}

	void OnCollisionEnter (Collision collision) {


		Destroy (collision.collider.gameObject);

		Destroy (this.gameObject);
	}
}
