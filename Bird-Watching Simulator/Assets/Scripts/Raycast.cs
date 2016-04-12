using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Raycast : MonoBehaviour {

	// bools for unlocking achievements
	public bool firstBirdFound = false; // find a bird
	public bool threeTypesFound = false; // find birds of three different types
	public bool rareBirdFound = false; // find a rare bird
	public bool ufoFound = false; // find a UFO - "Close Encounter"
	public bool bugFound = false; // find an insect - "Debugging"
	public bool fiveBirdsFound = false; // find five, ten, fifteen birds
	public bool tenBirdsFound = false;
	public bool fifteenBirdsFound = false;
	public bool nonbirdFound = false; // find an animal that is not a bird
	public bool sunFound = false; // stare at the sun - "Sungazing"
	public bool nothingFound = false; // find nothing during a play session - "Missing the Point"
	public bool threeLikeBirdsFound = false; // find three of the same bird - "Birds of a Feather"

	private bool thingFound = false;
	private int birdsFound = 0;
	private int likeFound = 0;
	private int typesFound = 0;
	private List<string> typesList = new List<string>();
	private bool gameOver = false;

	// Use this for initialization
	void Start () {
		Camera camera;
		//public double x = Screen.width/2;
		//public double y = Screen.height/2;
	}
	
	// Update is called once per frame
	void Update () {
		// send out a raycast from the center of the camera
		Vector3 forward = transform.TransformDirection(Vector3.forward);

		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		RaycastHit hit;

		// check for achievement completion
		if (Physics.Raycast(ray, out hit)) {
			thingFound = true;

			if (hit.transform.tag == "bird") {
				if (!typesList.Contains(hit.transform.name)) {
					birdsFound++; // if this bird hasn't already been found, increment number of birds found

					if (birdsFound == 1) {
						firstBirdFound = true; // if this is the first bird found, unlock the achievement
						Debug.Log("Achievement! Found 1 Bird");
					}
					else if (birdsFound == 5) {
						fiveBirdsFound = true; // likewise for the fifth...
						Debug.Log("Achievement! Found 5 Birds");
					}
					else if (birdsFound == 10) {
						tenBirdsFound = true; // ...and tenth...
						Debug.Log("Achievement! Found 10 Birds");
					}
					else if (birdsFound == 15) {
						fifteenBirdsFound = true; // ...and fifteenth birds found
						Debug.Log("Achievement! Found 15 Birds");
					}
						
					if (!typesList.Contains(hit.transform.name)) {
						typesList.Add(hit.transform.name); // add the bird to the list of bird types
						//Debug.Log(typesList[typesList.Count - 1]);
						typesFound++; // increment number of different types of birds found if the player has not yet found a bird of this type
							
						if (typesFound == 3) {
							threeTypesFound = true; // if the player has found three different types of birds, unlock the achievement
							Debug.Log("Achievement! Found 3 Different Species");
						}
					}
					else {						
						likeFound++; // otherwise, if the player has found this type of bird before, increment the number of like birds found...

						if (likeFound == 3) {
							threeLikeBirdsFound = true; // ...and if that number is three, unlock the achievement
							Debug.Log("Achievement! Birds of a Feather");
						}
					}
				} // end type check
			} // end bird check
			else if (hit.transform.tag == "rare") {
				birdsFound++;
				rareBirdFound = true; // if the player finds a rare bird, unlock the achievement
				Debug.Log("Achievement! Found a Rare Bird");
			}
			else if (hit.transform.tag == "ufo") {
				ufoFound = true; // if the player finds the UFO, unlock the achievement
				Debug.Log("Achievement! Close Encounter");
			}
			else if (hit.transform.tag == "bug") {
				bugFound = true; // likewise for the bug
				Debug.Log("Achievement! Debugging");
			}
			else if (hit.transform.tag == "sun") {
				sunFound = true;
				Debug.Log("Achievement! Sungazing");
			}

			if (gameOver == true && thingFound == false) {
				nothingFound = true; // if the player found nothing during the whole session, unlock the achievement
				Debug.Log("Achievement! Missing the Point");
			}
		} // end achievement check
	} // end Update
}
