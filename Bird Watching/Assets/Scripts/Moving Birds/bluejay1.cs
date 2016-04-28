using UnityEngine;
using System.Collections;

public class bluejay1 : MonoBehaviour {

	private Vector3 startPos;
	private Vector3 endPos = new Vector3(8, 7, 23);
	private Vector3 nextPos_1 = new Vector3(29, 7, -24);
	private Vector3 killPos;
	private Vector3 lastPos;

	private float timer_1;
	private float timer_2;

	private bool en2ndRoute = false;
	bool moving;

	public Animator anim;

	void Start () {

		startPos = transform.position;
		killPos = nextPos_1;
	}
	

	void Update () {

		anim.SetBool ("moving", moving);

		//Keeps track of time for 1st movement
		timer_1 += Time.deltaTime;

		//Handles first movement
		//Modify timer value to increase or decrease time between positions
		transform.position = Vector3.Lerp (startPos, endPos, (timer_1 * 0.29f));

		//Handles second movement
		//The difference between the time it takes to complete first movement and the value check below is the time the bird remains at one location
		if (timer_1 >= 15 && !en2ndRoute) {

			startPos = transform.position;
			endPos = nextPos_1;
			en2ndRoute = true;
		}

		if (en2ndRoute) {

			timer_2 += Time.deltaTime;
			transform.position = Vector3.Lerp (startPos, endPos, (timer_2 * 0.32f));
		}

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
