using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class birdScript : MonoBehaviour {

	public float timer;

	public Text timeDisplay;


	public Transform sparrowPrefab_1;
	public Transform sparrowPrefab_2;
	public Transform sparrowPrefab_3;
	public Transform sparrowPrefab_4;
	public Transform sparrowPrefab_5;
	public Transform sparrowPrefab_6;

	public Transform robinPrefab_1;
	public Transform robinPrefab_2;
	public Transform robinPrefab_3;
	public Transform robinPrefab_4;

	public Transform bluejayPrefab_1;
	public Transform bluejayPrefab_2;
	public Transform bluejayPrefab_3;



	private bool hasSpawnedSparrow_1 = false;
	private bool hasSpawnedSparrow_2 = false;
	private bool hasSpawnedSparrow_3 = false;
	private bool hasSpawnedSparrow_4 = false;
	private bool hasSpawnedSparrow_5 = false;
	private bool hasSpawnedSparrow_6 = false;

	private bool hasSpawnedRobin_1 = false;
	private bool hasSpawnedRobin_2 = false;
	private bool hasSpawnedRobin_3 = false;
	private bool hasSpawnedRobin_4 = false;

	private bool hasSpawnedBluejay_1 = false;
	private bool hasSpawnedBluejay_2 = false;
	private bool hasSpawnedBluejay_3 = false;



	public Vector3 sparrowPos_1;
	public Vector3 sparrowPos_2;
	public Vector3 sparrowPos_3;
	public Vector3 sparrowPos_4;
	public Vector3 sparrowPos_5;
	public Vector3 sparrowPos_6;

	public Vector3 robinPos_1;
	public Vector3 robinPos_2;
	public Vector3 robinPos_3;
	public Vector3 robinPos_4;

	public Vector3 bluejayPos_1;
	public Vector3 bluejayPos_2;
	public Vector3 bluejayPos_3;
	


	void Update () {
	
		//Used to keep track of time elapsed
		timer -= Time.deltaTime;
		timeDisplay.text = timer.ToString ("000");

		//Used to place birds into scene at specific times

		if (timer <= 118 && !hasSpawnedSparrow_4) {
			Debug.Log ("Spawned " + sparrowPrefab_4 + "4 at " + sparrowPos_4 + ".");
			Instantiate (sparrowPrefab_4, sparrowPos_4, Quaternion.identity);
			hasSpawnedSparrow_4 = true;
		}

		if (timer <= 115 && !hasSpawnedSparrow_1) {
			Debug.Log ("Spawned " + sparrowPrefab_1 + "1 at " + sparrowPos_1 + ".");
			Instantiate (sparrowPrefab_1, sparrowPos_1, Quaternion.identity);
			hasSpawnedSparrow_1 = true;
		}

		if (timer <= 109 && !hasSpawnedSparrow_2) {
			Debug.Log ("Spawned " + sparrowPrefab_2 + "2 at " + sparrowPos_2 + ".");
			Instantiate (sparrowPrefab_2, sparrowPos_2, Quaternion.identity);
			hasSpawnedSparrow_2 = true;
		}

		if (timer <= 100 && !hasSpawnedBluejay_1) {
			Debug.Log ("Spawned " + bluejayPrefab_1 + "1 at " + bluejayPos_1 + ".");
			Instantiate (bluejayPrefab_1, bluejayPos_1, Quaternion.identity);
			hasSpawnedBluejay_1 = true;
		}

		if (timer <= 90 && !hasSpawnedRobin_1) {
			Debug.Log ("Spawned " + robinPrefab_1 + "1 at " + robinPos_1 + ".");
			Instantiate (robinPrefab_1, robinPos_1, Quaternion.identity);
			hasSpawnedRobin_1 = true;
		}

		if (timer <= 75 && !hasSpawnedRobin_2) {
			Debug.Log ("Spawned " + robinPrefab_2 + "2 at " + robinPos_2 + ".");
			Instantiate (robinPrefab_2, robinPos_2, Quaternion.identity);
			hasSpawnedRobin_2 = true;
		}

		if (timer <= 69 && !hasSpawnedBluejay_2) {
			Debug.Log ("Spawned " + bluejayPrefab_2 + "2 at " + bluejayPos_2 + ".");
			Instantiate (bluejayPrefab_2, bluejayPos_2, Quaternion.identity);
			hasSpawnedBluejay_2 = true;
		}

		if (timer <= 60 && !hasSpawnedSparrow_3) {
			Debug.Log ("Spawned " + sparrowPrefab_3 + "3 at " + sparrowPos_3 + ".");
			Instantiate (sparrowPrefab_3, sparrowPos_3, Quaternion.identity);
			hasSpawnedSparrow_3 = true;
		}

		if (timer <= 50 && !hasSpawnedRobin_3) {
			Debug.Log ("Spawned " + robinPrefab_3 + "3 at " + robinPos_3 + ".");
			Instantiate (robinPrefab_3, robinPos_3, Quaternion.identity);
			hasSpawnedRobin_3 = true;
		}

		if (timer <= 40 && !hasSpawnedSparrow_5) {
			Debug.Log ("Spawned " + sparrowPrefab_5 + "5 at " + sparrowPos_5 + ".");
			Instantiate (sparrowPrefab_5, sparrowPos_5, Quaternion.identity);
			hasSpawnedSparrow_5 = true;
		}

		if (timer <= 35 && !hasSpawnedBluejay_3) {
			Debug.Log ("Spawned " + bluejayPrefab_3 + "3 at " + bluejayPos_3 + ".");
			Instantiate (bluejayPrefab_3, bluejayPos_3, Quaternion.identity);
			hasSpawnedBluejay_3 = true;
		}

		if (timer <= 20 && !hasSpawnedRobin_4) {
			Debug.Log ("Spawned " + robinPrefab_4+ "4 at " + robinPos_4 + ".");
			Instantiate (robinPrefab_4, robinPos_4, Quaternion.identity);
			hasSpawnedRobin_4 = true;
		}

		if (timer <= 20 && !hasSpawnedSparrow_6) {
			Debug.Log ("Spawned " + sparrowPrefab_6 + "6 at " + sparrowPos_6 + ".");
			Instantiate (sparrowPrefab_6, sparrowPos_6, Quaternion.identity);
			hasSpawnedSparrow_6 = true;
		}
			
	}
}
