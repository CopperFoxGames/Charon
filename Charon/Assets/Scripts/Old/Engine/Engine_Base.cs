using UnityEngine;
using System.Collections;

public class Engine_Base : MonoBehaviour {
	
	public virtual void print(string message) {
		Debug.Log ("[Info-" + gameObject.name + "] " + message);
	}
}
