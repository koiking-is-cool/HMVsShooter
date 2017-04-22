using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

	public Rigidbody wall;

	// Use this for initialization
	void Start () {
		wall.velocity = new Vector3 (0,2,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (wall.transform.position.y >= 3.00f) {
			wall.velocity = new Vector3 (0,-2,0);
		}
		else if (wall.transform.position.y <= -0.86f) {
			wall.velocity = new Vector3 (0,2,0);
		}
	}
}