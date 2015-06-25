using UnityEngine;
using System.Collections;

public class RestartScene : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width - ((Screen.width / 60)) - (Screen.width / 20), Screen.height / 60, Screen.width / 20, Screen.width / 20), "Restart")) {
			Application.LoadLevel("Unity-test-cupcake-scene");

		}
	}
}
