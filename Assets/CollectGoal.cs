using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectGoal : MonoBehaviour {
	public Text scoreboard;
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Poof");
		scoreboard.GetComponent<KeepScore> ().score ++;
		Destroy(other.gameObject);
	}
}
