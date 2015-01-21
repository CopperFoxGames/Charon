using UnityEngine;
using System.Collections;
using UnityEditor;

[InitializeOnLoad]
public class CharonEditorMainWindow
{

    static CharonEditorMainWindow()
    {
        gameSettingsObj = getGameSettings();

        SceneView.onSceneGUIDelegate += OnSceneGUI;

        button_itemEditor = Resources.LoadAssetAtPath("Assets/Editor/GUI/ItemEditor.png", typeof(Texture)) as Texture;
        button_levelPacker = Resources.LoadAssetAtPath("Assets/Editor/GUI/Level Packer.png", typeof(Texture)) as Texture;
    }
	
	static Texture button_itemEditor;
	static Texture button_levelPacker;
	static GameObject gameSettingsObj = null;
    static GameSettings gameSettings = null;

    public static bool menu_minimized = false;

    static float startWidth = 256;
    static float startHeight = 512;

    static Rect pos = new Rect(8, 32, 256, 256);

	static GameObject getGameSettings() {

		Object ret = GameObject.FindObjectOfType (typeof(GameSettings));

		return ret as GameObject;

	}
	
	static void OnSceneGUI(SceneView sceneView)
    {
        //begins drawing to the gui
        Handles.BeginGUI();
        if (gameSettingsObj)
        {

            //minimizing the main window
		    if(menu_minimized==false)
            {
			    pos.width = startWidth;
			    pos.height = startHeight;
		    }else{
			    pos.width = 100;
			    pos.height = 20;
		    }
		    
            //drawinf the window to the scene view
		    pos = GUI.Window (0, pos, windowFunction, "Settings");
		    
            //drawing the level editinb buttons
		    GUI.BeginGroup(new Rect(Screen.width-80, 8, 80, Screen.height-16));
		    GUI.Button (new Rect (8, 8, 48, 48), button_itemEditor);
		    GUI.Button (new Rect (8, 72, 48, 48), button_levelPacker);
		    GUI.EndGroup ();

        }
        else
        {
            GUILayout.Label("No GameSettings object found! please create one!");
            GUILayout.Button("Refresh");
            if (GUILayout.Button("Create GameSettings"))
            {
                GameObject obj = new GameObject();
                obj.name = "GameSettings";
                obj.AddComponent<GameSettings>();
                gameSettingsObj = obj;
            }
        }
        //ends drawing to the gui
        Handles.EndGUI();
	}
	
	
	static void windowFunction(int windowID)
    {
		
		if(GUI.Button(new Rect(5,-1,32,16), menu_minimized ? "+" : "-"))
        {
			menu_minimized = !menu_minimized;
		}

		if(!menu_minimized)
        {
			GUILayout.Label (":");
		}
		
		GUI.DragWindow ();
	}
}
