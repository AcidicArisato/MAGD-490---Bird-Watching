using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class birdScript : MonoBehaviour {

	public float timer;

	public Text timeDisplay;

	public Transform bluejayPrefab_1;
//	public Transform robinPrefab_1;
//	public Transform sparrowPrefab_1;

	private bool hasSpawnedBluejay_1 = false;
//	private bool hasSpawnedRobin_1 = false;
//	private bool hasSpawnedSparrow_1 = false;

	public Vector3 bluejayPos_1;
//	public Vector3 robinPos_1;
//	public Vector3 sparrowPos_1;
	

	void Update () {
	
		//Used to keep track of time elapsed
		timer -= Time.deltaTime;
		timeDisplay.text = timer.ToString ("000");

		//Used to place birds into scene at specific times
		if (timer <= 110 && !hasSpawnedBluejay_1) {
			Instantiate (bluejayPrefab_1, bluejayPos_1, Quaternion.identity);
			hasSpawnedBluejay_1 = true;
		}

		/*if (timer <= 105 && !hasSpawnedRobin_1) {
			Instantiate (robinPrefab_1, robinPos_1, Quaternion.identity);
			hasSpawnedRobin_1 = true;
		}*/

		/*if (timer <= 100 && !hasSpawnedSparrow_1) {
			Instantiate (sparrowPrefab_1, sparrowPos_1, Quaternion.identity);
			hasSpawnedSparrow_1 = true;
		}*/

	}
}
