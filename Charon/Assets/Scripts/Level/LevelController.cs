using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelController : MonoBehaviour {

	static int levelWidth = 32;
	static int levelHeight = 32;
	public static GameObject[,] tiles;
	public Camera camera;

	// Use this for initialization
	void Start () {
		tiles = new GameObject[levelWidth,levelHeight];

		//first we go trough and place all the tiles
		for(int placey = 0; placey<levelHeight; placey++) {
			for(int placex = 0; placex<levelWidth; placex++) {
				GameObject obj = Instantiate(Resources.Load ("Prefabs/Tiles/TileGrass")) as GameObject;
				obj.transform.position = new Vector3(placex, placey, 0);
				tiles[placex, placey] = obj;
				Tile tile = obj.GetComponent(typeof(Tile)) as Tile;
				tile.posX = placex;
				tile.posY = placey;
				tile.onPlace();
			}
		}

		//then we go trough again and update the tile's layout, to make the tiles connect
		for(int placey = 0; placey<levelHeight; placey++) {
			for(int placex = 0; placex<levelWidth; placex++) {
				GameObject obj = tiles[placex, placey];
				Tile tile = obj.GetComponent(typeof(Tile)) as Tile;
				tile.updateSides();
			}
		}

		camera.transform.position = new Vector3 (levelWidth / 2, levelHeight / 2, -10);
	}

	public static GameObject getTile(int x, int y) {
		if(x<0||x>=levelWidth||y<0||y>=levelHeight) {
			return null;
		}else{
			return tiles[x,y];
		}
	}
	
	public static int getLevelWidth() {
		return levelWidth;
	}
	
	public static int getLevelHeight() {
		return levelHeight;
	}
}
