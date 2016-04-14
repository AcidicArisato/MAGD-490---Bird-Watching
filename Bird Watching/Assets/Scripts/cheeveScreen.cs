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

	void Awake () {
		totalCheeves = 0;
	}

	void Start () {

		//Simple achievements
		if (statsManager.seeOne = true) {
			cheeve01.text = ("Got One! - Spot 1 bird");
			got01.SetActive (true);
			totalCheeves++;
		} else {
			cheeve01.text = ("Got One! - ?????????");
		}
		if (statsManager.seeFive = true) {
			cheeve02.text = ("One For Each Finger - Spot 5 birds");
			got02.SetActive (true);
			totalCheeves++;
		} else {
			cheeve02.text = ("One For Each Finger - ??????????");
		}
		if (statsManager.seeTen = true) {
			cheeve03.text = ("Seen the Flock - Spot 10 birds");
			got03.SetActive (true);
			totalCheeves++;
		} else {
			cheeve03.text = ("Seen the Flock - ???????????");
		}
		if (statsManager.seeFifteen = true) {
			cheeve04.text = ("Full Volery - Spot 15 birds");
			got04.SetActive (true);
			totalCheeves++;
		} else {
			cheeve04.text = ("Full Volery - ???????????");
		}
		if (statsManager.birdType1 = true) {
			cheeve05.text = ("Run of the Feather - Spot a Sparrow");
			got05.SetActive (true);
			totalCheeves++;
		} else {
			cheeve05.text = ("Run of the Feather - ????????????");
		}
		if (statsManager.birdType2 = true) {
			cheeve06.text = ("Yuuum - Spot a Robin");
			got06.SetActive (true);
			totalCheeves++;
		} else {
			cheeve06.text = ("Yuuum - ??????????");
		}
		if (statsManager.birdType3 = true) {
			cheeve07.text = ("Why so Blue? - Spot a Bluejay");
			got07.SetActive (true);
			totalCheeves++;
		} else {
			cheeve07.text = ("Why so Blue? - ????????????");
		}
		if (statsManager.oneOfEach = true) {
			cheeve08.text = ("Birds of a Feather - Spot 1 of each type of common bird");
			got08.SetActive (true);
			totalCheeves++;
		} else {
			cheeve08.text = ("Birds of a Feather - ???????????????????????????");
		}
		if (statsManager.rareBird = true) {
			cheeve09.text = ("No One Will Believe You - Spot a rare bird");
			got09.SetActive (true);
			totalCheeves++;
		} else {
			cheeve10.text = ("No One Will Believe You - ?????????????");
		}
		//Obscure achievements
		if (statsManager.bothRare = true) {
			cheeve10.text = ("Double Rainbow - Spot both rare birds");
			got10.SetActive (true);
			totalCheeves++;
		} else {
			cheeve10.text = ("????????????? - ?????????????????");
		}
		if (statsManager.nonBird = true) {
			cheeve11.text = ("Stay Focused! - Spot a non-bird creature");
			got11.SetActive (true);
			totalCheeves++;
		} else {
			cheeve11.text = ("???????????? - ?????????????????????");
		}
		if (statsManager.findInsect = true) {
			cheeve12.text = ("Eagle Eyes - Spot the insect");
			got12.SetActive (true);
			totalCheeves++;
		} else {
			cheeve12.text = ("????????? - ?????????????");
		}
		if (statsManager.stareSun = true) {
			cheeve13.text = ("Icarus Syndrome - Stare at the sun for too long");
			got13.SetActive (true);
			totalCheeves++;
		} else {
			cheeve13.text = ("?????????????? - ???????????????????????");
		}
		if (statsManager.noBirds = true) {
			cheeve14.text = ("Completely Disinterested - Don't spot a single bird in a session");
			got14.SetActive (true);
			totalCheeves++;
		} else {
			cheeve14.text = ("??????????????????????? - ????????????????????");
		}
		if (statsManager.ufo = true) {
			cheeve15.text = ("I Want To Believe - Spot the UFO");
			got15.SetActive (true);
			totalCheeves++;
		} else {
			cheeve15.text = ("????????????? - ??????????");
		}
		//Trophy
		if (totalCheeves == 15) {
			gotAll.SetActive (true);
		}

	}

}
