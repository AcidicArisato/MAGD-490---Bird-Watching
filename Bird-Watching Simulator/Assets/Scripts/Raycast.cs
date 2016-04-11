using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

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

		if(Physics.Raycast(ray, out hit)){
			Debug.Log(hit.transform.name); 
			Debug.DrawLine(transform.position, hit.transform.position, Color.red);
		}
	} // end Update
}
