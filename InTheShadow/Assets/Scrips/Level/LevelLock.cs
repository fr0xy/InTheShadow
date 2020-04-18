using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLock : MonoBehaviour{
  //This field should be set by the inspector
	[SerializeField] int levelRequirement;
	public Button ButtonScript;
	public bool testMod = false;
	private Transform Button;
	private Text Text;
	public void Start(){
		int currentLevel = PlayerPrefs.GetInt("level");
		if (PlayerPrefs.GetInt("testMod") == 1)
			currentLevel = 5;
		bool levelUnlocked = currentLevel >= levelRequirement;
		Button = gameObject.transform.Find("Button");
		if (Button != null) {
			ButtonScript = Button.gameObject.GetComponent<Button>();
			Text = Button.Find("Text").gameObject.GetComponent<Text>();
			ButtonScript.interactable = levelUnlocked;
			if (currentLevel > levelRequirement) {
				Text.color = Color.green;
			} else if (currentLevel == levelRequirement) {
				Text.color = Color.gray;
			} else if (currentLevel < levelRequirement) {
				Text.color = Color.red;
			}
		}
	}
}