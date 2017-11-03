using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {
	public Scoreboard sb;

	// Use this for initialization
	void Start () {
		sb = GameObject.FindGameObjectWithTag ("Score").GetComponent<Scoreboard> ();
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("Collided");
		if (collision.gameObject.tag == "Player") {
			Debug.Log ("Collided with player");
			sb.IncrementScore ();
			Destroy (gameObject);
		}
	}
}
