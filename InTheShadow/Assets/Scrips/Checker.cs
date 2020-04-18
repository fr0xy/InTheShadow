using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour {
	public bool objectIsOk = false;
	// Use this for initialization
	void Start () {
		objectIsOk = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (objectIsOk == false && GetComponent<RotationChecker>().isOK == true && GetComponent<PositionChecker>().isOK == true)
			objectIsOk = true;
	}
}
