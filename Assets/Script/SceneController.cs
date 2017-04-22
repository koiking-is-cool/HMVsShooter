using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

	public Text time;

	// Use this for initialization
	void Start () {
		startProcess ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void startProcess(){
		StartCoroutine (countDown());
	}
	IEnumerator countDown(){
		for(int i=10;i>=0;i--){
			time.text = "Time : " + i.ToString ();
			yield return new WaitForSeconds (1);
		}
		time.text = "Time's Up!!";
	}
}
