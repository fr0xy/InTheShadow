using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour {
	public GameObject WinUI;
	public int currentLevel;
	public int currentLevelSave;
	public GameObject[] ObjectList;
	private bool hasWin = false;
	// Use this for initialization
	void Start () {
		currentLevelSave = PlayerPrefs.GetInt("level");
	}
	
	// Update is called once per frame
	void Update () {
		hasWin = true;
		for (int i = 0; i < ObjectList.Length; i++)
		{
			if(ObjectList[i].GetComponent<Checker>().objectIsOk == false)
				hasWin = false;
		}
		if (hasWin == true)
			Win();
	}
	public void Win() {
		if (currentLevel > currentLevelSave)
			PlayerPrefs.SetInt("level", currentLevel);
		for (int i = 0; i < ObjectList.Length; i++)
		{
			ObjectList[i].GetComponent<ObjectMove>().allowMove = false;
			ObjectList[i].GetComponent<ObjectMove>().allowXRotation = false;
			ObjectList[i].GetComponent<ObjectMove>().allowYRotation = false;
		}
		WinUI.SetActive(true);
	}
}
