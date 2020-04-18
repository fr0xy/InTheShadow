using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChecker : MonoBehaviour {
	public bool isOK;
	public float posX;
	public float posY;
	public float posZ;
	public float margeX;
	public float margeY;
	public float margeZ;
	public float actualPosX;
	public float actualPosY;
	public float actualPosZ;
	// Use this for initialization
	void Start () {
		isOK = false;
	}
	
	// Update is called once per frame
	void Update () {
		actualPosX = transform.position.x;
		actualPosY = transform.position.y;
		actualPosZ = transform.position.z;
		if (actualPosX < posX + margeX && actualPosX > posX - margeX) {
			if (actualPosY < posY + margeY && actualPosY > posY - margeY) {
				if (actualPosZ < posZ + margeZ && actualPosZ > posZ - margeZ)
					isOK = true;
				else
					isOK = false;
			}
			else
				isOK = false;
		}
		else
			isOK = false;
	}
}
