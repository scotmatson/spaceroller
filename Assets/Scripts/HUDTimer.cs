using UnityEngine;
using System.Collections;

public class HUDTimer : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// If the timer hasn't zero'd out and the player is still alive
		// continue to count down.
		if (GameVariables.timer > 0 && GameVariables.lives > 0) {
			guiText.text = "Timer: " + GameVariables.timer;
			GameVariables.timer -= Time.deltaTime;
		}
	}
}
