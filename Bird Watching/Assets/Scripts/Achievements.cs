using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Achievements : MonoBehaviour {
	//private RaycastScript raycastScript;
	private GameObject raycastScript;
	public Text achievementText;
	private float time = 0;
	private Vector3 target = new Vector3(0, -115, 0);
	private Vector3 hide = new Vector3(0, -190, 0);

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

	// Use this for initialization
	void Start () {
		raycastScript = GameObject.Find("Main Camera");
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
            if (achievementText.transform.position != target)
                achievementText.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
				//achievementText.transform.Translate(0, 75, 0);
			
			time += Time.deltaTime;
			if (time > 5) {
				if (achievementText.transform.position != hide) {
					//achievementText.transform.Translate(0, -190, 0); // wait for 5 seconds after displaying the achievement, then reset the text and hide it
                    achievementText.transform.Translate(Vector3.up * Time.deltaTime * -1, Space.World);
                    achievementText.text = defaultText;
				}
			}
		}
	} // end Update
}
