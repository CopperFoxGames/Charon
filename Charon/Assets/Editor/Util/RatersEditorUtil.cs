using UnityEngine;
using System.Collections;
using UnityEditor;

public class RatersEditorUtil {

	public static bool drawSplash() {
		EditorGUILayout.LabelField ("Rater193's Engine");
		EditorGUILayout.LabelField ("For freinds and team mates only!");
		EditorGUILayout.LabelField ("All ips will be logged!");
		EditorGUILayout.Space ();
		EditorGUILayout.LabelField ("Anyone caught using the engine");
		EditorGUILayout.LabelField ("without permission, will be");
		EditorGUILayout.LabelField ("terminated!");
		EditorGUILayout.Space ();
		EditorGUILayout.LabelField ("Activated", "True");
		EditorGUILayout.Space ();
		return true;
	}

}
