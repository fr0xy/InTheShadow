using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationChecker : MonoBehaviour {
	public bool isOK;
	public float rotX;
	public float rotY;
	public float rotZ;
	public float margeX = 5;
	public float margeY = 5;
	public float margeZ = 5;
	[SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		eulerAngX = marge0(transform.localEulerAngles.x);
        eulerAngY = marge0(transform.localEulerAngles.y);
        eulerAngZ = marge0(transform.localEulerAngles.z);
		if (transform.eulerAngles.x < rotX + margeX && transform.eulerAngles.x > rotX - margeX) {
			if (transform.eulerAngles.y < rotY + margeY && transform.eulerAngles.y > rotY - margeY) {
				if (transform.eulerAngles.z < rotZ + margeZ && transform.eulerAngles.z > rotZ - margeZ) {
					isOK = true;
				}	else
					isOK = false;
			} else
				isOK = false;
		} else
			isOK = false;
	}
	float marge0(float enter) {
		if (enter >= 180)
			return enter - 360;
		return enter;
	}
}
