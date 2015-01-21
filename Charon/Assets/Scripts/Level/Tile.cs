using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tile : MonoBehaviour {

	//these are the objects that we have for "visual" effects
	public GameObject tile_ul;
	public GameObject tile_ur;
	public GameObject tile_ll;
	public GameObject tile_lr;
	public int posX;
	public int posY;

	// Use this for initialization
	public virtual void Start () {
		if(!tile_ul || !tile_ur || !tile_ll || !tile_lr) {
			Debug.LogWarning("["+gameObject.name+"] Not all the children are set! destroying tile!");
			Destroy(gameObject);
		}
	}

	public virtual void onPlace() {

	}

	public virtual void updateSides() {
		int tarX, tarY;
		GameObject tar;
		Vector2 pos = new Vector2(posX, posY);
		float x = 0;
		float y = 0;
		float z = 0;
		
		SpriteRenderer sr = tile_ul.GetComponent (typeof(SpriteRenderer)) as SpriteRenderer;

		Renderer r = sr.renderer;

		//mesh.uv = uvs.ToArray ();

		//mesh.Optimize ();
	}

	//public void updateTiles
	
	// Update is called once per frame
	public virtual void Update () {

	}
}
