using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public Rigidbody shot1;
	public Rigidbody shot2;

	// Use this for initialization
	void Start () {
		shot1.velocity = new Vector3 (1,0,0);
		shot2.velocity = new Vector3 (-1,0,0);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
