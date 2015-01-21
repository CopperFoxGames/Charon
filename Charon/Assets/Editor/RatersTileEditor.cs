using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Tile))]
public class RatersTileEditor : Editor {
	public override void OnInspectorGUI() {
		Tile tile = target as Tile;
		

		EditorGUI.BeginDisabledGroup (!RatersEditorUtil.drawSplash ());

		EditorGUILayout.LabelField ("Upper Left Tile");
		tile.tile_ul = EditorGUILayout.ObjectField(tile.tile_ul, typeof(GameObject), true) as GameObject;

		EditorGUILayout.Space ();
		EditorGUILayout.LabelField ("Upper Right Tile");
		tile.tile_ur = EditorGUILayout.ObjectField(tile.tile_ur, typeof(GameObject), true) as GameObject;

		EditorGUILayout.Space ();
		EditorGUILayout.LabelField ("Lower Left Tile");
		tile.tile_ll = EditorGUILayout.ObjectField(tile.tile_ll, typeof(GameObject), true) as GameObject;
		
		EditorGUILayout.Space ();
		EditorGUILayout.LabelField ("Lower Right Tile");
		tile.tile_lr = EditorGUILayout.ObjectField(tile.tile_lr, typeof(GameObject), true) as GameObject;
		
		EditorGUILayout.Space ();
		if(GUILayout.Button ("Destroy")==true){
			DestroyImmediate (tile.gameObject);
		}

		EditorGUI.EndDisabledGroup ();
	}

	// this creates the menu
	[MenuItem("rater193/Editor/Tiles")]
	private static void NewMenuOption()
	{


		Debug.Log ("Removing!");
		GameObject obj = Selection.activeGameObject;
		if(obj) {
			DestroyImmediate(obj);
		}
	}
	
	// this enables/disables the menu, by returning true/faflse.
	[MenuItem("Assets/ProcessTexture", true)]
	private static bool NewMenuOptionValidation()
	{
		return true;
	}


	[MenuItem("Assets/ProcessTexture")]
	private static void DoSomethingWithTexture()
	{
		Debug.Log ("Test");
	}

	// Note that we pass the same path, and also pass "true" to the second argument.
	[MenuItem("Assets/ProcessTexture", true)]
	private static bool DoSomethingWithTextureValidation()
	{
		return true;
	}
}
