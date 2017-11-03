using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	private MapGenerator mg;
	private KeepScore sb;
	private float elapsed;
	// Use this for initialization
	void Start () {
		mg = GameObject.FindGameObjectWithTag ("MapSpawner").GetComponent<MapGenerator>();
		sb = GameObject.FindGameObjectWithTag ("Score").GetComponent<KeepScore>();
		elapsed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (sb.score < mg.goalCount) {
			elapsed += Time.deltaTime;
			GetComponent<Text> ().text = elapsed.ToString ("0000.00");
		}
	}
}
