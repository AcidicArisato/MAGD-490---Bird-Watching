using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

	public string firstExit;
	public string secondExit;
	public string thirdExit;

	//Scene loaders
	public void loadFirstScene ()
	{
		SceneManager.LoadScene (firstExit, LoadSceneMode.Single);
	}

	public void loadSecondScene ()
	{
		SceneManager.LoadScene (secondExit, LoadSceneMode.Single);
	}

	public void loadThirdScene ()
	{
		SceneManager.LoadScene (thirdExit, LoadSceneMode.Single);
	}

	//Quits game
	public void quitGame ()
	{
		Application.Quit ();
	}

}
