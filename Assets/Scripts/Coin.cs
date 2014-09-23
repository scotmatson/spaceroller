using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.name == "Ball") {
			++GameVariables.points;
			GameVariables.timer += 3;
			Destroy (gameObject);
		}
	}
}
