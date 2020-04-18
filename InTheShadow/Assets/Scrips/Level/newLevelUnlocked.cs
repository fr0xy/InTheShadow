using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLevelUnlocked : MonoBehaviour {
	public int currentLevel;
	public int lastLevel;
	public ParticleSystem Fireworks1;
	public ParticleSystem Fireworks2;
	// Use this for initialization
	void Start () {
		currentLevel = PlayerPrefs.GetInt("level");
		lastLevel = PlayerPrefs.GetInt("lastLevel");
		if (lastLevel < currentLevel) {
			StartCoroutine(PlayFireworks());
			for (int i = 0; i < currentLevel; i++)
			{
				gameObject.GetComponent<Rotate>().right();
			}
			PlayerPrefs.SetInt("lastLevel", currentLevel);
		}
	}
	IEnumerator PlayFireworks() {
		for (int i = 0; i < 5; i++)
		{
			Fireworks1.Play();
			Fireworks2.Play();
			yield return new WaitForSeconds(0.5f);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
