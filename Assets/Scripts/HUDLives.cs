using UnityEngine;
using System.Collections;

public class HUDLives : MonoBehaviour {
		
	// Update is called once per frame
	void Update () {
		guiText.text = "Lives: " + GameVariables.lives;
	}
}
