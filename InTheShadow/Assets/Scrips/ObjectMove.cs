using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {
	public bool isInside = false;
	public bool isHolding = false;
	public float speed = 0.3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isInside == true || isHolding == true)
			GetInput();
		if (isHolding == true)
			GetAxis();
	}
	void GetInput() {
		if (Input.GetMouseButton(0))
			isHolding = true;
		if (Input.GetMouseButtonUp(0))
			isHolding = false;
	}
	void GetAxis() {
		gameObject.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, Input.GetAxis("Mouse X") * speed, 0));
	}
	void OnMouseEnter() {
		Debug.Log("Enter");
		isInside = true;
	}
	void OnMouseExit() {
		Debug.Log("Exit");
		isInside = false;
	}
}
