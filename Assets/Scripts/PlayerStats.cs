using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	Vector3 startPosition = new Vector3();
	public bool alive = false;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameVariables.timer <= 0) {
			Destroy (gameObject);
		}
		if (!alive) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.name == "Sun" || collider.gameObject.name == "Space") {
			--GameVariables.lives;
			if(GameVariables.lives > 0)
				Respawn ();
			else
				alive = false;
		}
	}

	public void Respawn() {
		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
		transform.position = startPosition;
	}
	
}
