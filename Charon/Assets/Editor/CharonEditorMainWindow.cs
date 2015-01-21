using UnityEngine;
using System.Collections;
using UnityEditor;

public class CharonEditorMainWindow : EditorWindow {

	public CharonEditorMainWindow() {
		SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
		SceneView.onSceneGUIDelegate += this.OnSceneGUI;
	}
	//test
	public static bool menu_minimized = false;
	
	static float startWidth = 256;
	static float startHeight = 512;

	Rect pos = new Rect (8, 32, 256, 256);


	
	[MenuItem("Charon/LevelEditor")]
	static void ShowWindow ()
	{
		GetWindow(typeof(CharonEditorMainWindow), false, "Level Editor", true);
	}
	
	void OnFocus()
	{
		SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
		SceneView.onSceneGUIDelegate += this.OnSceneGUI;
	}
	
	void OnDestroy()
	{
		SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
	}
	
	void OnSceneGUI(SceneView sceneView)
	{
		Handles.BeginGUI();

		if(menu_minimized==false) {
			pos.width = startWidth;
			pos.height = startHeight;
		}else{
			pos.width = 100;
			pos.height = 20;
		}

		pos = GUI.Window (0, pos, windowFunction, "");
		Handles.EndGUI();
		
	}


	void windowFunction(int windowID) {
		GUI.DragWindow ();
	}
}
