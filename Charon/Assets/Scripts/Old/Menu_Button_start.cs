using UnityEngine;
using System.Collections;

public class Menu_Button_start : Menu_Button_Base {
	void OnMouseDown() {
		Application.LoadLevel ("Spaceship");
	}
}
