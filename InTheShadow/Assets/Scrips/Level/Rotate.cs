using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public int currentYRotation = 0;
	public float rotationSpeed = 5;
	public void right() {
		StartCoroutine(rotate90(1));
	}
	public void left() {
		StartCoroutine(rotate90(-1));
	}
	IEnumerator rotate90(int direction) {
		float routineRotation = 0;
		while ( routineRotation < 90 ) {
			transform.Rotate(new Vector3(0, rotationSpeed * direction, 0));
			routineRotation += rotationSpeed;
			yield return new WaitForSeconds(0.05f);
		}
	}
}
