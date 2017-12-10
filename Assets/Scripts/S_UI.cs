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
	public GameObject pauseScreenOptions;
	public GameObject levelCompleteScreen;
	public GameObject gameOverScreen;

	public GameObject environment;
	GameObject gameManager;
//	public GameObject gameManager;

	// Use this for initialization
	void Start ()
	{
		ShowStartScreen ();

		//customerManager = GameObject.Find ("CustomerManager");
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
		pauseScreenOptions.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);

		environment.SetActive (false);
//		customerManager.SetActive (false);
	}

	public void LevelSelectButton()
	{
		startScreen.SetActive (false);
		levelSelectScreen.SetActive (true);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (false);
		pauseScreen.SetActive (false);
		pauseScreenOptions.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void Level1Button()
	{
		Time.timeScale = 1.0f;

		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (true);
		pauseScreen.SetActive (false);
		pauseScreenOptions.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);

		environment.SetActive (true);
//		customerManager.SetActive (true);

		//gameManager.GetComponent<S_SpawnEnvironment> ().enabled = true;
		//gameManager.GetComponent<S_InventoryManager> ().enabled = true;
		gameManager.GetComponent<S_CustomerSpawn> ().enabled = true;
		//gameManager.GetComponent<S_BarController> ().enabled = true;

		//environment = GameObject.Find ("Environment");
		
	}

	public void OptionsButton ()
	{
		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (true);
		creditsScreen.SetActive (false);
		HUD.SetActive (false);
		pauseScreen.SetActive (false);
		pauseScreenOptions.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void MusicSlider()
	{

	}

	public void SFXSlider()
	{

	}

	public void CreditsScreen()
	{
		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (true);
		HUD.SetActive (false);
		pauseScreen.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void ExitGame()
	{
		print ("Exited Game");
		Application.Quit ();
	}

	public void PauseButton()
	{
		Time.timeScale = 0.0f;

		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (false);
		pauseScreen.SetActive (true);
		pauseScreenOptions.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void ResumeButton()
	{
		Time.timeScale = 1.0f;

		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (true);
		pauseScreen.SetActive (false);
		pauseScreenOptions.SetActive (false);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void PauseScreenOptions()
	{
		startScreen.SetActive (false);
		levelSelectScreen.SetActive (false);
		optionsScreen.SetActive (false);
		creditsScreen.SetActive (false);
		HUD.SetActive (false);
		pauseScreen.SetActive (false);
		pauseScreenOptions.SetActive (true);
		levelCompleteScreen.SetActive (false);
		gameOverScreen.SetActive (false);
	}

	public void PauseExitButton()
	{
		LevelSelectButton ();
		//gameManager.GetComponent<S_SpawnEnvironment> ().enabled = false;
		//gameManager.GetComponent<S_InventoryManager> ().enabled = false;
		gameManager.GetComponent<S_CustomerSpawn> ().enabled = false;
		//gameManager.GetComponent<S_BarController> ().enabled = false;
		//Destroy (environment);

		gameManager.GetComponent<S_BarController> ().barPoint1InUse = false;
		gameManager.GetComponent<S_BarController> ().barPoint2InUse = false;
		gameManager.GetComponent<S_BarController> ().barPoint3InUse = false;
//		gameManager.GetComponent<S_BarController> ().barPoint4InUse = false;
//		gameManager.GetComponent<S_BarController> ().barPoint5InUse = false;
//		gameManager.GetComponent<S_BarController> ().barPoint6InUse = false;

		gameManager.GetComponent<S_CustomerSpawn> ().spawn1InUse = false;
		gameManager.GetComponent<S_CustomerSpawn> ().spawn2InUse = false;
		gameManager.GetComponent<S_CustomerSpawn> ().spawn3InUse = false;
//		customerManager.GetComponent<S_CustomerSpawn> ().spawn4InUse = false;
//		customerManager.GetComponent<S_CustomerSpawn> ().spawn5InUse = false;
//		customerManager.GetComponent<S_CustomerSpawn> ().spawn6InUse = false;

		for (int i = 0; i < gameManager.GetComponent<S_CustomerSpawn> ().currentCustomersList.Count; i++)
		{
			Destroy (gameManager.GetComponent<S_CustomerSpawn> ().currentCustomersList [i].gameObject);
		}


		gameManager.GetComponent<S_CustomerSpawn> ().currentCustomersList.Clear();
		gameManager.GetComponent<S_CustomerSpawn> ().currentCustomers = gameManager.GetComponent<S_CustomerSpawn> ().currentCustomersList.Count;
		gameManager.GetComponent<S_CustomerSpawn> ().enabled = false;

//		gameManager.GetComponent<S_CustomerSpawn> ().currentCustomersList.Clear ();
//		gameManager.GetComponent<S_CustomerSpawn> ().currentCustomers = gameManager.GetComponent<S_CustomerSpawn> ().currentCustomersList.Count;
		environment.SetActive (false);

	}
}
