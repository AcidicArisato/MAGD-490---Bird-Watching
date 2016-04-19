using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cheeveScreen : MonoBehaviour {

	//Achievements
	public Text cheeve01;
	public Text cheeve02;
	public Text cheeve03;
	public Text cheeve04;
	public Text cheeve05;
	public Text cheeve06;
	public Text cheeve07;
	public Text cheeve08;
	public Text cheeve09;
	public Text cheeve10;
	public Text cheeve11;
	public Text cheeve12;
	public Text cheeve13;
	public Text cheeve14;
	public Text cheeve15;

	//Image to be displayed if player does not have achievement
	public GameObject miss01;
	public GameObject miss02;
	public GameObject miss03;
	public GameObject miss04;
	public GameObject miss05;
	public GameObject miss06;
	public GameObject miss07;
	public GameObject miss08;
	public GameObject miss09;
	public GameObject miss10;
	public GameObject miss11;
	public GameObject miss12;
	public GameObject miss13;
	public GameObject miss14;
	public GameObject miss15;

	//Overwrite image for if player got achievement
	public GameObject got01;
	public GameObject got02;
	public GameObject got03;
	public GameObject got04;
	public GameObject got05;
	public GameObject got06;
	public GameObject got07;
	public GameObject got08;
	public GameObject got09;
	public GameObject got10;
	public GameObject got11;
	public GameObject got12;
	public GameObject got13;
	public GameObject got14;
	public GameObject got15;

	//Shows when player has gotten all achievements
	public int totalCheeves;
	public GameObject gotAll;
	public Text congrats;

	void Awake () {
		totalCheeves = 0;
	}

	void Start () {

		//Simple achievements
		if (statsManager.seeOne == true) {
			cheeve01.text = ("Got One! - Spot 1 bird");
			miss01.SetActive (false);
			got01.SetActive (true);
			totalCheeves++;
		} else {
			cheeve01.text = ("Got One! - ?????????");
		}
		if (statsManager.seeFive == true) {
			cheeve02.text = ("One For Each Finger - Spot 5 birds");
			miss02.SetActive (false);
			got02.SetActive (true);
			totalCheeves++;
		} else {
			cheeve02.text = ("One For Each Finger - ??????????");
		}
		if (statsManager.seeTen == true) {
			cheeve03.text = ("Seen the Flock - Spot 10 birds");
			miss03.SetActive (false);
			got03.SetActive (true);
			totalCheeves++;
		} else {
			cheeve03.text = ("Seen the Flock - ???????????");
		}
		if (statsManager.seeFifteen == true) {
			cheeve04.text = ("Full Volery - Spot 15 birds");
			miss04.SetActive (false);
			got04.SetActive (true);
			totalCheeves++;
		} else {
			cheeve04.text = ("Full Volery - ???????????");
		}
		if (statsManager.birdType1 == true) {
			cheeve05.text = ("Run of the Feather - Spot a Sparrow");
			miss05.SetActive (false);
			got05.SetActive (true);
			totalCheeves++;
		} else {
			cheeve05.text = ("Run of the Feather - ????????????");
		}
		if (statsManager.birdType2 == true) {
			cheeve06.text = ("Yuuum - Spot a Robin");
			miss06.SetActive (false);
			got06.SetActive (true);
			totalCheeves++;
		} else {
			cheeve06.text = ("Yuuum - ??????????");
		}
		if (statsManager.birdType3 == true) {
			cheeve07.text = ("Why so Blue? - Spot a Bluejay");
			miss07.SetActive (false);
			got07.SetActive (true);
			totalCheeves++;
		} else {
			cheeve07.text = ("Why so Blue? - ????????????");
		}
		if (statsManager.oneOfEach == true) {
			cheeve08.text = ("Birds of a Feather - Spot 1 of each type of common bird");
			miss08.SetActive (false);
			got08.SetActive (true);
			totalCheeves++;
		} else {
			cheeve08.text = ("Birds of a Feather - ???????????????????????????");
		}
		if (statsManager.rareBird == true) {
			cheeve09.text = ("No One Will Believe You - Spot a rare bird");
			miss09.SetActive (false);
			got09.SetActive (true);
			totalCheeves++;
		} else {
			cheeve09.text = ("No One Will Believe You - ?????????????");
		}
		//Obscure achievements
		if (statsManager.bothRare == true) {
			cheeve10.text = ("Double Rainbow - Spot both rare birds");
			miss10.SetActive (false);
			got10.SetActive (true);
			totalCheeves++;
		} else {
			cheeve10.text = ("????????????? - ?????????????????");
		}
		if (statsManager.nonBird == true) {
			cheeve11.text = ("Stay Focused! - Spot a non-bird creature");
			miss11.SetActive (false);
			got11.SetActive (true);
			totalCheeves++;
		} else {
			cheeve11.text = ("???????????? - ?????????????????????");
		}
		if (statsManager.findInsect == true) {
			cheeve12.text = ("Eagle Eyes - Spot the insect");
			miss12.SetActive (false);
			got12.SetActive (true);
			totalCheeves++;
		} else {
			cheeve12.text = ("????????? - ?????????????");
		}
		if (statsManager.stareSun == true) {
			cheeve13.text = ("Icarus Syndrome - Stare at the sun for too long");
			miss13.SetActive (false);
			got13.SetActive (true);
			totalCheeves++;
		} else {
			cheeve13.text = ("?????????????? - ???????????????????????");
		}
		if (statsManager.noBirds == true) {
			cheeve14.text = ("Completely Disinterested - Don't spot a single bird in a session");
			miss14.SetActive (false);
			got14.SetActive (true);
			totalCheeves++;
		} else {
			cheeve14.text = ("??????????????????????? - ????????????????????");
		}
		if (statsManager.ufo == true) {
			cheeve15.text = ("I Want To Believe - Spot the UFO");
			miss15.SetActive (false);
			got15.SetActive (true);
			totalCheeves++;
		} else {
			cheeve15.text = ("????????????? - ??????????");
		}
		//Trophy
		if (totalCheeves == 15) {
			gotAll.SetActive (true);
			congrats.text = ("You have gotten all the achievements! You are a master bird watcher!");
		}

	}

}
