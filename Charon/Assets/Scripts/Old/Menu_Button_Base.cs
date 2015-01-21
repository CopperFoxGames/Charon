using UnityEngine;
using System.Collections;

public class Menu_Button_Base : MonoBehaviour {
	
	float scalePlace;
	float rotationPlace;
	float animSpeed;
	
	// Use this for initialization
	public virtual void Start () {
		scalePlace = Random.Range(0f,10000f);
		rotationPlace = Random.Range(0f,10000f);
		animSpeed = Random.Range (1f, 2f);
	}
	
	// Update is called once per frame
	public virtual void Update () {
		scalePlace += Time.deltaTime*3*animSpeed;
		rotationPlace += Time.deltaTime*2*animSpeed;
		
		float scaleAmm = Mathf.Sin (scalePlace);
		scaleAmm = scaleAmm / Mathf.PI;
		scaleAmm = scaleAmm;
		scaleAmm += 1f;
		
		float rotAmm = Mathf.Sin (rotationPlace);
		rotAmm = rotAmm / Mathf.PI;
		rotAmm = rotAmm * 20;
		
		Quaternion rot = gameObject.transform.rotation;
		transform.eulerAngles = new Vector3(0, 0, rotAmm);
		transform.localScale = new Vector3 (scaleAmm/2+0.5f, scaleAmm/2+0.5f, 0);
	}
}
