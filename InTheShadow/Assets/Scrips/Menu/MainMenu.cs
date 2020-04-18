using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	// Use this for initialization
	private AudioSource Music;
	void Start () {
		Music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadNormal() {
		PlayerPrefs.SetInt("testMod", 0);
		SceneManager.LoadScene("LevelMap");
	}
	public void LoadTest() {
		PlayerPrefs.SetInt("testMod", 1);
		SceneManager.LoadScene("LevelMap");
	}
	public void Reset() {
		PlayerPrefs.SetInt("level", 0);
		PlayerPrefs.SetInt("lastLevel", 0);
	}
	public void Quit() {
		Application.Quit();
	}
	public void Mute() {
		Music.mute = !Music.mute;
	}
}
