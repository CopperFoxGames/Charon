using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject obj = Resources.Load ("Test") as GameObject;
		Instantiate (obj);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
