using UnityEngine;
using System.Collections;

public class HUDPoints : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		guiText.text = "Points: " + GameVariables.points;
	}
}
