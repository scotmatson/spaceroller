using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float moveSpeed = 100f;
	public float turnSpeed = 500f;

	// Update is called once per frame
	void Update () {
		Movement ();
	}
	
	void Movement() {

		if (Input.GetKey(KeyCode.W)) {
			rigidbody.AddForce(Vector3.forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)) {
			rigidbody.AddForce(Vector3.back * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)) {
			rigidbody.AddForce(Vector3.right * moveSpeed * Time.deltaTime);

		}
		if (Input.GetKey(KeyCode.A)) {
			rigidbody.AddForce(Vector3.left * moveSpeed * Time.deltaTime);

		}
		
	}
}