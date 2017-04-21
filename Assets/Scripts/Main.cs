using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	void Start () {
	
	}
	
   	void Update () {
	
	}


	void OnGUI(){
		Rect rect = new Rect (0f,0f,Screen.width,Screen.height);
		GUI.skin.label.fontSize = 40;
		GUI.Label (rect,"hello Jenkins");
	}
}
