using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectMove : MonoBehaviour {
	public bool allowXRotation = false;
	public bool allowYRotation = false;
	public bool allowMove = false;
	public bool isInside = false;
	public bool willMove = false;
	public bool isHolding = false;
	public GameObject OtherObject = null;
	public float rotateSpeed = 0.3f;
	public float moveSpeed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isInside == true || isHolding == true)
			GetInput();
		if (isHolding == true)
			GetMouvement();
	}
	void GetInput() {
		if (Input.GetMouseButton(0) && (OtherObject == null || OtherObject.GetComponent<ObjectMove>().isHolding == false))
			isHolding = true;
		if (Input.GetMouseButtonUp(0)) {
			willMove = false;
			isHolding = false;
		}
		if (Input.GetKeyDown(KeyCode.LeftControl))
			willMove = true;
		if (Input.GetKeyUp(KeyCode.LeftControl))
			willMove = false;
		if (Input.GetKeyDown(KeyCode.R))
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("LevelMap");

	}
	void GetMouvement() {
		if (allowYRotation && willMove == false)
			transform.RotateAround(transform.position, new Vector3(1, 0, 0), Input.GetAxis("Mouse Y") * rotateSpeed);
		if (allowXRotation && willMove == false)
			transform.RotateAround(transform.position, new Vector3(0, 1, 0), Input.GetAxis("Mouse X") * rotateSpeed);
		if (allowMove && willMove) {
			transform.position = new Vector3(transform.position.x + Input.GetAxis("Mouse X") * moveSpeed, transform.position.y + Input.GetAxis("Mouse Y") * moveSpeed, transform.position.z);
			// transform.Translate(-Input.GetAxis("Mouse X") * moveSpeed, Input.GetAxis("Mouse Y") * moveSpeed, 0);
		}
	}
	void OnMouseEnter() {
		isInside = true;
	}
	void OnMouseExit() {
		isInside = false;
	}
}
