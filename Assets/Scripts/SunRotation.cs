using UnityEngine;
using System.Collections;

public class SunRotation : MonoBehaviour {

	public float rotateSpeed = 20f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.right * rotateSpeed * Time.deltaTime);
	}
}
