using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_UI : MonoBehaviour
{

	public GameObject startScreen;
	public GameObject levelSelectScreen;
	public GameObject optionsScreen;
	public GameObject creditsScreen;
	public GameObject HUD;
	public GameObject pauseScreen;
	public GameObject levelCompleteScreen;
	public GameObject gameOverScreen;

	public GameObject environment;
	GameObject gameManager;


	// Use this for initialization
	void Start ()
	{
		ShowStartScreen ();

		gameManager = GameObject.Find ("GameManager");
	}
	
	// Update is called once per frame
	void Update ()
	{

		
	}

	public void ShowStartScreen()
	{
		startScreen.SetActive (true);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (false);
		pauseScreen.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void LevelSelectButton()
	{
		startScreen.SetActive (false);
		levelSelectScreen.SetActive (true);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (false);
		pauseScreen.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void Level1Button()
	{
		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (true);
		pauseScreen.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);

		environment.SetActive (true);
		gameManager.GetComponent<S_InventoryManager> ().enabled = true;
		gameManager.GetComponent<S_CustomerSpawn> ().enabled = true;
		gameManager.GetComponent<S_BarController> ().enabled = true;
	}
}
