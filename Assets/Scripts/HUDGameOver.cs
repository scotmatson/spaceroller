using UnityEngine;
using System.Collections;

public class HUDGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameVariables.lives == 0) {
			guiText.text = "Game Over";
		}
	}
}
