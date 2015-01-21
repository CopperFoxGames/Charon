using UnityEngine;
using System.Collections;
using UnityEditor;

public class CharonSettingsWindow : EditorWindow {

	Rect pos = new Rect (8, 32, 256, 256);
	
	bool showGrid = true;
	Vector2 tiles = new Vector2(6,6);
	
	[MenuItem("Charon/LevelEditor")]
	static void ShowWindow ()
	{
		GetWindow(typeof(CharonSettingsWindow), false, "Level Editor", true);
	}
	
	void OnFocus()
	{
		// Remove and re-add the sceneGUI delegate
		SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
		SceneView.onSceneGUIDelegate += this.OnSceneGUI;
	}
	
	void OnDestroy()
	{
		SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
	}
	
	void OnSceneGUI(SceneView sceneView)
	{
		float size_x = tiles.x;
		float size_y = tiles.y;
		
		if (showGrid)
		{
			// Draw all X grid lines
			for ( int i = 0; i <= size_x; i++ )
			{
				// draw a line equal to x and the full height
				Handles.DrawLine( new Vector3(i,0,0), new Vector3(i,size_y,0) );
			}
			
			// Draw all y grid lines
			for ( int i = 0; i <= size_y; i++ )
			{
				// draw a line equal to x and the full height
				Handles.DrawLine( new Vector3(0,i,0), new Vector3(size_x,i,0) );
			}
		}
		
		// check if mouse is over any tiles
		Vector3 mousePosition = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition).origin;
		
		if ( (mousePosition.x > 0 && mousePosition.x < size_x) && (mousePosition.y > 0 && mousePosition.y < size_y) )
		{
			// mouse is within a tile
			int hoverTile_x = (int)Mathf.Floor( mousePosition.x );
			int hoverTile_y = (int)Mathf.Floor( mousePosition.y );
			
			// DRAW RECT OVER TILE HERE
			
		}
		Handles.color = Color.blue;
		Handles.BeginGUI();
			pos = GUI.Window (0, pos, windowFunction, "");
		Handles.EndGUI();
		
	}


	void windowFunction(int windowID) {
		GUI.DragWindow ();
	}
}
