using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Achievements : MonoBehaviour {
	//private RaycastScript raycastScript;
	private GameObject raycastScript;
	public Text achievementText;
	private float time = 0;
	private Vector3 target = new Vector3(0, -100, 0);
	private Vector3 hide = new Vector3(0, -250, 0);

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

	// Use this for initialization
	void Start () {
		raycastScript = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (raycastScript.GetComponent<RaycastScript>().firstBirdFound == true) {
			if (!achievementText.text.Contains(firstBirdFoundText))
				achievementText.text += firstBirdFoundText;
		}
		else if (raycastScript.GetComponent<RaycastScript>().fiveBirdsFound == true) {
			if (!achievementText.text.Contains(fiveBirdsFoundText))
				achievementText.text += fiveBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().tenBirdsFound == true) {
			if (!achievementText.text.Contains(tenBirdsFoundText))
				achievementText.text += tenBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().fifteenBirdsFound == true) {
			if (!achievementText.text.Contains(fifteenBirdsFoundText))
			achievementText.text += fifteenBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().threeTypesFound == true) {
			if (!achievementText.text.Contains(fifteenBirdsFoundText))
				achievementText.text += threeTypesFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().threeLikeBirdsFound == true) {
			if (!achievementText.text.Contains(threeLikeBirdsFoundText))
				achievementText.text += threeLikeBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().rareBirdFound == true) {
			if (!achievementText.text.Contains(rareBirdFoundText))
				achievementText.text += rareBirdFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().ufoFound == true) {
			if (!achievementText.text.Contains(ufoFoundText))
				achievementText.text += ufoFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().bugFound == true) {
			if (!achievementText.text.Contains(bugFoundText))
				achievementText.text += bugFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().sunFound == true) {
			if (!achievementText.text.Contains(sunFoundText))
				achievementText.text += sunFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().nonbirdFound == true) {
			if (!achievementText.text.Contains(nonbirdFoundText))
				achievementText.text += nonbirdFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().nothingFound == true) {
			if (!achievementText.text.Contains(nothingFoundText))
				achievementText.text += nothingFoundText;
		}

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

		/*if (raycastScript.GetComponent<RaycastScript>().firstBirdFound == true || raycastScript.GetComponent<RaycastScript>().fiveBirdsFound == true || 
			raycastScript.GetComponent<RaycastScript>().tenBirdsFound == true || raycastScript.GetComponent<RaycastScript>().fifteenBirdsFound == true ||
			raycastScript.GetComponent<RaycastScript>().threeTypesFound == true || raycastScript.GetComponent<RaycastScript>().threeLikeBirdsFound == true || 
			raycastScript.GetComponent<RaycastScript>().rareBirdFound == true || raycastScript.GetComponent<RaycastScript>().ufoFound == true ||
			raycastScript.GetComponent<RaycastScript>().bugFound == true || raycastScript.GetComponent<RaycastScript>().nonbirdFound == true || 
			raycastScript.GetComponent<RaycastScript>().sunFound == true || raycastScript.GetComponent<RaycastScript>().nothingFound == true) 
		{
			gotAchievement = true;
			rising = true;
			raycastScript.GetComponent<RaycastScript>().firstBirdFound = false;
			raycastScript.GetComponent<RaycastScript>().fiveBirdsFound = false; 
			raycastScript.GetComponent<RaycastScript>().tenBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().fifteenBirdsFound = false;
			raycastScript.GetComponent<RaycastScript>().threeTypesFound = false;
			raycastScript.GetComponent<RaycastScript>().threeLikeBirdsFound = false; 
			raycastScript.GetComponent<RaycastScript>().rareBirdFound = false;
			raycastScript.GetComponent<RaycastScript>().ufoFound = false;
			raycastScript.GetComponent<RaycastScript>().bugFound = false;
			raycastScript.GetComponent<RaycastScript>().nonbirdFound = false; 
			raycastScript.GetComponent<RaycastScript>().sunFound = false;
			raycastScript.GetComponent<RaycastScript>().nothingFound = false;

		}*/

		if (gotAchievement == true) {
			if (achievementText.transform.localPosition.y < target.y && rising == true) {
				achievementText.transform.Translate(Vector3.up * 2.5f, Space.World);
				//Debug.Log("rising");
			}
			else {
				rising = false;
				Debug.Log(achievementText.transform.localPosition.y);
				//Debug.Log("lowering");
				time += Time.deltaTime;
			
				// wait for 5 seconds after displaying the achievement, then reset the text and hide it
				if (time > 5 && rising == false) {
					if (achievementText.transform.localPosition.y > hide.y) {
                   		achievementText.transform.Translate(Vector3.up * Time.deltaTime * -2.5f, Space.World);
					}
					else {
						gotAchievement = false;
						achievementText.text = defaultText;
					}
				}
			}
		}
	} // end Update
}
