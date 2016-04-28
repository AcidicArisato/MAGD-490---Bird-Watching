using UnityEngine;
using System.Collections;

public class sparrow1 : MonoBehaviour {

	private Vector3 startPos;
	private Vector3 endPos = new Vector3(0, 7, 20);
//	private Vector3 nextPos_1 = new Vector3(-2, 4, 2);
	private Vector3 killPos = new Vector3 (0, 7, 20);
	private Vector3 lastPos;

	private float timer_1;
	bool moving;

	public Animator anim;

	void Start () {

		startPos = transform.position;
	}
	

	void Update () {

		anim.SetBool ("moving", moving);

		//Keeps track of time for 1st movement
		timer_1 += Time.deltaTime;

		//Handles first movement
		//Modify timer value to increase or decrease time between positions
		transform.position = Vector3.Lerp (startPos, endPos, (timer_1 * 0.12f));

		//Deletes bird after it leaves the scene
		if (transform.position == killPos)
			Destroy (gameObject);

		//For animation
		if (lastPos == transform.position) {

			moving = false;
		} else {

			moving = true;
		}
	}

	// Checks if bird is moving
	void lateUpdate () {

		lastPos = transform.position;
	}
}
