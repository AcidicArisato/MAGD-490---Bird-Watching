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
	private Vector3 hide = new Vector3(0, -450, 0);

	// strings for achievement titles
	private string defaultText = "Achievement!";
	private string firstBirdFoundText = " First Bird Found";
	private string threeTypesFoundText = " Three Species Found";
	private string rareBirdFoundText = " One in a Million";
	private string ufoFoundText = " Close Encounter";
	private string bugFoundText = " Debugging";
	private string fiveBirdsFoundText = " Found 5 Birds";
	private string tenBirdsFoundText = " Found 10 Birds";
	private string fifteenBirdsFoundText = " Found 15 Birds";
	private string nonbirdFoundText = " No Feathers";
	private string sunFoundText = " Sungazing";
	private string nothingFoundText = " Missing the Point";
	private string threeLikeBirdsFoundText = " Birds of a Feather";

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
			achievementText.text += fiveBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().tenBirdsFound == true) {
			achievementText.text += tenBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().fifteenBirdsFound == true) {
			achievementText.text += fifteenBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().threeTypesFound == true) {
			achievementText.text += threeTypesFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().threeLikeBirdsFound == true) {
			achievementText.text += threeLikeBirdsFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().rareBirdFound == true) {
			achievementText.text += rareBirdFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().ufoFound == true) {
			achievementText.text += ufoFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().bugFound == true) {
			achievementText.text += bugFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().sunFound == true) {
			achievementText.text += sunFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().nonbirdFound == true) {
			achievementText.text += nonbirdFoundText;
			
		}
		else if (raycastScript.GetComponent<RaycastScript>().nothingFound == true) {
			achievementText.text += nothingFoundText;
		}

		if (raycastScript.GetComponent<RaycastScript>().firstBirdFound == true || raycastScript.GetComponent<RaycastScript>().fiveBirdsFound == true || 
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

		}

		if (gotAchievement == true) {
			if (achievementText.transform.localPosition.y < target.y && rising == true) {
				achievementText.transform.Translate(Vector3.up * 2.5f, Space.World);
				Debug.Log("rising");
			}
			else {
				rising = false;
				Debug.Log(achievementText.transform.localPosition.y);
				Debug.Log("lowering");
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
