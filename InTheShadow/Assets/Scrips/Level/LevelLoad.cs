using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {
	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Menu");
	}
	public void LoadLevel(int level) {
		SceneManager.LoadScene("Level" + level);
	}
}
