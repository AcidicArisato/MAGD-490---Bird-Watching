using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Achievements : MonoBehaviour {
	//private RaycastScript raycastScript;
	private GameObject raycastScript;
	public Text achievementText;
	private float time = 0;
	private Vector3 target = new Vector3(0, -140, 0);
	private Vector3 hide = new Vector3(0, -200, 0);

	// strings for achievement titles
	[HideInInspector]
	public string defaultText = "Achievement!";
	public string firstBirdFoundText = " First Bird Found";
	public string threeTypesFoundText = " Three Species Found";
	public string rareBirdFoundText = " One in a Million";
	public string ufoFoundText = " Close Encounter";
	public string bugFoundText = " Debugging";
	public string fiveBirdsFoundText = " Found 5 Birds";
	public string tenBirdsFoundText = " Found 10 Birds";
	public string fifteenBirdsFoundText = " Found 15 Birds";
	public string nonbirdFoundText = " No Feathers";
	public string sunFoundText = " Sungazing";
	public string nothingFoundText = " Missing the Point";
	public string threeLikeBirdsFoundText = " Birds of a Feather";

	public bool gotAchievement = false;
	public bool rising = false;

	private List<string> displayQueue = new List<string>();
	private int i = 0;

	//private GameObject newText;

	// Use this for initialization
	void Start () {
		raycastScript = GameObject.Find("Player");
		achievementText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (raycastScript.GetComponent<RaycastScript>().firstBirdFound == true) {
			//if (!achievementText.text.Contains(firstBirdFoundText))
				//achievementText.text = defaultText + firstBirdFoundText;
			if (!displayQueue.Contains(firstBirdFoundText))
				displayQueue.Add(firstBirdFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + firstBirdFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().fiveBirdsFound == true) {
			//if (!achievementText.text.Contains(fiveBirdsFoundText))
				//achievementText.text = defaultText + fiveBirdsFoundText;
			if (!displayQueue.Contains(fiveBirdsFoundText))
				displayQueue.Add(fiveBirdsFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + fiveBirdsFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().tenBirdsFound == true) {
			//if (!achievementText.text.Contains(tenBirdsFoundText))
				//achievementText.text = defaultText + tenBirdsFoundText;
			if (!displayQueue.Contains(tenBirdsFoundText))
				displayQueue.Add(tenBirdsFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + tenBirdsFoundText;*/
		}
		 
		if (raycastScript.GetComponent<RaycastScript>().fifteenBirdsFound == true) {
			//if (!achievementText.text.Contains(fifteenBirdsFoundText))
				//achievementText.text = defaultText + fifteenBirdsFoundText;
			if (!displayQueue.Contains(fifteenBirdsFoundText))
				displayQueue.Add(fifteenBirdsFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + fifteenBirdsFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().threeTypesFound == true) {
			//if (!achievementText.text.Contains(threeTypesFoundText))
				//achievementText.text = defaultText + threeTypesFoundText;
			if (!displayQueue.Contains(threeTypesFoundText))
				displayQueue.Add(threeTypesFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + threeTypesFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().threeLikeBirdsFound == true) {
			//if (!achievementText.text.Contains(threeLikeBirdsFoundText))
				//achievementText.text = defaultText + threeLikeBirdsFoundText;
			if (!displayQueue.Contains(threeLikeBirdsFoundText))
				displayQueue.Add(threeLikeBirdsFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + threeLikeBirdsFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().rareBirdFound == true) {
			//if (!achievementText.text.Contains(rareBirdFoundText))
				//achievementText.text = defaultText + rareBirdFoundText;
			if (!displayQueue.Contains(rareBirdFoundText))
				displayQueue.Add(rareBirdFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + rareBirdFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().ufoFound == true) {
			//if (!achievementText.text.Contains(ufoFoundText))
				//achievementText.text = defaultText + ufoFoundText;
			if (!displayQueue.Contains(ufoFoundText))
				displayQueue.Add(ufoFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + ufoFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().bugFound == true) {
			//if (!achievementText.text.Contains(bugFoundText))
				//achievementText.text = defaultText + bugFoundText;
			if (!displayQueue.Contains(bugFoundText))
				displayQueue.Add(bugFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + bugFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().sunFound == true) {
			//if (!achievementText.text.Contains(sunFoundText))
				//achievementText.text = defaultText + sunFoundText;
			if (!displayQueue.Contains(sunFoundText))
				displayQueue.Add(sunFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + sunFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().nonbirdFound == true) {
			//if (!achievementText.text.Contains(nonbirdFoundText))
				//achievementText.text = defaultText + nonbirdFoundText;
			if (!displayQueue.Contains(nonbirdFoundText))
				displayQueue.Add(nonbirdFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + nonbirdFoundText;*/
		}

		if (raycastScript.GetComponent<RaycastScript>().nothingFound == true) {
			//if (!achievementText.text.Contains(nothingFoundText))
				//achievementText.text = defaultText + nothingFoundText;
			if (!displayQueue.Contains(nothingFoundText))
				displayQueue.Add(nothingFoundText);
			/*newText = new GameObject();
			newText.AddComponent<Text>();
			newText.GetComponent<Text>().text = defaultText + nothingFoundText;*/
		}

		//if (GameObject.Find("newText") != null)
			//newText.transform.position = new Vector3(0, -250, 0);

		if (raycastScript.GetComponent<RaycastScript>().displayFirstBirdFound == true || raycastScript.GetComponent<RaycastScript>().displayFiveBirdsFound == true || 
			raycastScript.GetComponent<RaycastScript>().displayTenBirdsFound == true || raycastScript.GetComponent<RaycastScript>().displayFifteenBirdsFound == true || 
			raycastScript.GetComponent<RaycastScript>().displayThreeTypesFound == true || raycastScript.GetComponent<RaycastScript>().displayRareBirdFound == true || 
			raycastScript.GetComponent<RaycastScript>().displayThreeLikeBirdsFound == true || raycastScript.GetComponent<RaycastScript>().displaySunFound == true ||
			raycastScript.GetComponent<RaycastScript>().displayBugFound == true || raycastScript.GetComponent<RaycastScript>().displayUfoFound == true || 
			raycastScript.GetComponent<RaycastScript>().displayNothingFound == true || raycastScript.GetComponent<RaycastScript>().displayNonbirdFound == true)
		{
			gotAchievement = true;
			rising = true;
			raycastScript.GetComponent<RaycastScript>().displayFirstBirdFound = false;
			raycastScript.GetComponent<RaycastScript>().displayFiveBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displayTenBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displayFifteenBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displayThreeTypesFound = false;
			raycastScript.GetComponent<RaycastScript>().displayRareBirdFound = false;
			raycastScript.GetComponent<RaycastScript>().displayThreeLikeBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displaySunFound = false;
			raycastScript.GetComponent<RaycastScript>().displayBugFound = false;
			raycastScript.GetComponent<RaycastScript>().displayUfoFound = false;
			raycastScript.GetComponent<RaycastScript>().displayNothingFound = false;
			raycastScript.GetComponent<RaycastScript>().displayNonbirdFound = false;
		}

		if (gotAchievement == true) {
			achievementText.enabled = true;
			DisplayAchievements(displayQueue, i);
		}
	} // end Update

	public void DisplayAchievements(List<string> displayQueue, int counter) {
		if (counter < displayQueue.Count) {
			achievementText.text = defaultText + displayQueue[counter];
			time += Time.deltaTime;
			if (time > 5) {
				//displayQueue.RemoveAt(counter);
				counter++;
				i = counter;
				time = 0;
				DisplayAchievements(displayQueue, counter);
			}
		}
		else {
			achievementText.enabled = false;
			achievementText.text = "";
			i = 0;
			//gotAchievement = false;
			raycastScript.GetComponent<RaycastScript>().displayFirstBirdFound = false;
			raycastScript.GetComponent<RaycastScript>().displayFiveBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displayTenBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displayFifteenBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displayThreeTypesFound = false;
			raycastScript.GetComponent<RaycastScript>().displayRareBirdFound = false;
			raycastScript.GetComponent<RaycastScript>().displayThreeLikeBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().displaySunFound = false;
			raycastScript.GetComponent<RaycastScript>().displayBugFound = false;
			raycastScript.GetComponent<RaycastScript>().displayUfoFound = false;
			raycastScript.GetComponent<RaycastScript>().displayNothingFound = false;
			raycastScript.GetComponent<RaycastScript>().displayNonbirdFound = false;
		}
	} // end DisplayAchievements
}
