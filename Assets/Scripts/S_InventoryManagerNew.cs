using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_InventoryManagerNew : MonoBehaviour
{
	// current whole ingredients
	public int currentLemons = 0;
	public int currentBananas = 0;
	public int currentOranges = 0;
	public int currentStrawberries = 0;
	public int currentIce = 0;

	// current sliced/peeled ingredients
	public int currentPeeledLemons = 0;
	public int currentSlicedLemons = 0;
	public int currentPeeledBananas = 0;
	public int currentSlicedBananas = 0;
	public int currentPeeledOranges = 0;
	public int currentSlicedOranges = 0;
	public int currentPeeledStrawberries = 0;
	public int currentSlicedStrawberries = 0;

	// whole ingredients prefabs
//	public GameObject lemon;
//	public GameObject banana;
//	public GameObject orange;
//	public GameObject strawberry;
//	public GameObject ice;
	public GameObject lemon1;
	public GameObject lemon2;
	public GameObject lemon3;
	public GameObject lemon4;
	public GameObject lemon5;
	public GameObject banana1;
	public GameObject banana2;
	public GameObject banana3;
	public GameObject banana4;
	public GameObject banana5;
	public GameObject orange1;
	public GameObject orange2;
	public GameObject orange3;
	public GameObject orange4;
	public GameObject orange5;
	public GameObject strawberry1;
	public GameObject strawberry2;
	public GameObject strawberry3;
	public GameObject strawberry4;
	public GameObject strawberry5;

	//peeled ingredients prefabs
//	public GameObject peeledLemon;
//	public GameObject peeledBanana;
//	public GameObject peeledOrange;
//	public GameObject peeledStrawberry;


	// sliced ingredients prefabs
//	public GameObject lemonSlice;
//	public GameObject bananaSlice;
//	public GameObject orangeSlice;
//	public GameObject strawberrySlice;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// show current whole ingredients
		ShowLemons ();
		ShowBananas ();
		ShowOranges ();
		ShowStrawberries ();

		// display current peeled ingredients
		ShowPeeledLemons ();
		ShowPeeledBananas ();
		ShowPeeledOranges ();
		ShowPeeledStrawberries ();

		// display current sliced ingredients
		ShowSlicedLemons ();
		ShowSlicedBananas ();
		ShowSlicedOranges ();
		ShowSlicedStrawberries ();
	}

	void ShowLemons()
	{
		if (currentLemons == 0)
		{
			lemon1.SetActive (false);
			lemon2.SetActive (false);
			lemon3.SetActive (false);
			lemon4.SetActive (false);
			lemon5.SetActive (false);
		}
		else if (currentLemons == 1)
		{
			lemon1.SetActive (true);
			lemon2.SetActive (false);
			lemon3.SetActive (false);
			lemon4.SetActive (false);
			lemon5.SetActive (false);
		}
		else if (currentLemons == 2)
		{
			lemon1.SetActive (true);
			lemon2.SetActive (true);
			lemon3.SetActive (false);
			lemon4.SetActive (false);
			lemon5.SetActive (false);
		}
		else if (currentLemons == 3)
		{
			lemon1.SetActive (true);
			lemon2.SetActive (true);
			lemon3.SetActive (true);
			lemon4.SetActive (false);
			lemon5.SetActive (false);
		}
		else if (currentLemons == 4)
		{
			lemon1.SetActive (true);
			lemon2.SetActive (true);
			lemon3.SetActive (true);
			lemon4.SetActive (true);
			lemon5.SetActive (false);
		}
		else if (currentLemons >= 5)
		{
			lemon1.SetActive (true);
			lemon2.SetActive (true);
			lemon3.SetActive (true);
			lemon4.SetActive (true);
			lemon5.SetActive (true);
		}
	}

	void ShowBananas()
	{
		if (currentBananas == 0)
		{
			banana1.SetActive (false);
			banana2.SetActive (false);
			banana3.SetActive (false);
			banana4.SetActive (false);
			banana5.SetActive (false);
		}
		else if (currentBananas == 1)
		{
			banana1.SetActive (true);
			banana2.SetActive (false);
			banana3.SetActive (false);
			banana4.SetActive (false);
			banana5.SetActive (false);
		}
		else if (currentBananas == 2)
		{
			banana1.SetActive (true);
			banana2.SetActive (true);
			banana3.SetActive (false);
			banana4.SetActive (false);
			banana5.SetActive (false);
		}
		else if (currentBananas == 3)
		{
			banana1.SetActive (true);
			banana2.SetActive (true);
			banana3.SetActive (true);
			banana4.SetActive (false);
			banana5.SetActive (false);
		}
		else if (currentBananas == 4)
		{
			banana1.SetActive (true);
			banana2.SetActive (true);
			banana3.SetActive (true);
			banana4.SetActive (true);
			banana5.SetActive (false);
		}
		else if (currentBananas >= 5)
		{
			banana1.SetActive (true);
			banana2.SetActive (true);
			banana3.SetActive (true);
			banana4.SetActive (true);
			banana5.SetActive (true);
		}
	}

	void ShowOranges()
	{
		if (currentOranges == 0)
		{
			orange1.SetActive (false);
			orange2.SetActive (false);
			orange3.SetActive (false);
			orange4.SetActive (false);
			orange5.SetActive (false);
		}
		else if (currentOranges == 1)
		{
			orange1.SetActive (true);
			orange2.SetActive (false);
			orange3.SetActive (false);
			orange4.SetActive (false);
			orange5.SetActive (false);
		}
		else if (currentOranges == 2)
		{
			orange1.SetActive (true);
			orange2.SetActive (true);
			orange3.SetActive (false);
			orange4.SetActive (false);
			orange5.SetActive (false);
		}
		else if (currentOranges == 3)
		{
			orange1.SetActive (true);
			orange2.SetActive (true);
			orange3.SetActive (true);
			orange4.SetActive (false);
			orange5.SetActive (false);
		}
		else if (currentOranges == 4)
		{
			orange1.SetActive (true);
			orange2.SetActive (true);
			orange3.SetActive (true);
			orange4.SetActive (true);
			orange5.SetActive (false);
		}
		else if (currentOranges >= 5)
		{
			orange1.SetActive (true);
			orange2.SetActive (true);
			orange3.SetActive (true);
			orange4.SetActive (true);
			orange5.SetActive (true);
		}
	}

	void ShowStrawberries()
	{
		if (currentStrawberries == 0)
		{
			strawberry1.SetActive (false);
			strawberry2.SetActive (false);
			strawberry3.SetActive (false);
			strawberry4.SetActive (false);
			strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 1)
		{
			strawberry1.SetActive (true);
			strawberry2.SetActive (false);
			strawberry3.SetActive (false);
			strawberry4.SetActive (false);
			strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 2)
		{
			strawberry1.SetActive (true);
			strawberry2.SetActive (true);
			strawberry3.SetActive (false);
			strawberry4.SetActive (false);
			strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 3)
		{
			strawberry1.SetActive (true);
			strawberry2.SetActive (true);
			strawberry3.SetActive (true);
			strawberry4.SetActive (false);
			strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 4)
		{
			strawberry1.SetActive (true);
			strawberry2.SetActive (true);
			strawberry3.SetActive (true);
			strawberry4.SetActive (true);
			strawberry5.SetActive (false);
		}
		else if (currentStrawberries >= 5)
		{
			strawberry1.SetActive (true);
			strawberry2.SetActive (true);
			strawberry3.SetActive (true);
			strawberry4.SetActive (true);
			strawberry5.SetActive (true);
		}
	}

	void ShowPeeledLemons()
	{
		if (currentPeeledLemons == 0)
		{

		}
		else if (currentPeeledLemons == 1)
		{

		}
		else if (currentPeeledLemons == 2)
		{

		}
		else if (currentPeeledLemons == 3)
		{

		}
		else if (currentPeeledLemons == 4)
		{

		}
		else if (currentPeeledLemons >= 5)
		{

		}
	}

	void ShowPeeledBananas()
	{
		if (currentPeeledBananas == 0)
		{

		}
		else if (currentPeeledBananas == 1)
		{

		}
		else if (currentPeeledBananas == 2)
		{

		}
		else if (currentPeeledBananas == 3)
		{

		}
		else if (currentPeeledBananas == 4)
		{

		}
		else if (currentPeeledBananas >= 5)
		{

		}
	}

	void ShowPeeledOranges()
	{
		if (currentPeeledOranges == 0)
		{

		}
		else if (currentPeeledOranges == 1)
		{

		}
		else if (currentPeeledOranges == 2)
		{

		}
		else if (currentPeeledOranges == 3)
		{

		}
		else if (currentPeeledOranges == 4)
		{

		}
		else if (currentPeeledOranges >= 5)
		{

		}
	}

	void ShowPeeledStrawberries()
	{
		if (currentPeeledStrawberries == 0)
		{

		}
		else if (currentPeeledStrawberries == 1)
		{

		}
		else if (currentPeeledStrawberries == 2)
		{

		}
		else if (currentPeeledStrawberries == 3)
		{

		}
		else if (currentPeeledStrawberries == 4)
		{

		}
		else if (currentPeeledStrawberries >= 5)
		{

		}
	}
		
	void ShowSlicedLemons()
	{
		if (currentSlicedLemons == 0)
		{

		}
		else if (currentSlicedLemons == 1)
		{

		}
		else if (currentSlicedLemons == 2)
		{

		}
		else if (currentSlicedLemons == 3)
		{

		}
		else if (currentSlicedLemons == 4)
		{

		}
		else if (currentSlicedLemons >= 5)
		{

		}
	}

	void ShowSlicedBananas()
	{
		if (currentSlicedBananas == 0)
		{

		}
		else if (currentSlicedBananas == 1)
		{

		}
		else if (currentSlicedBananas == 2)
		{

		}
		else if (currentSlicedBananas == 3)
		{

		}
		else if (currentSlicedBananas == 4)
		{

		}
		else if (currentSlicedBananas >= 5)
		{

		}
	}

	void ShowSlicedOranges()
	{
		if (currentSlicedOranges == 0)
		{

		}
		else if (currentSlicedOranges == 1)
		{

		}
		else if (currentSlicedOranges == 2)
		{

		}
		else if (currentSlicedOranges == 3)
		{

		}
		else if (currentSlicedOranges == 4)
		{

		}
		else if (currentSlicedOranges >= 5)
		{

		}
	}

	void ShowSlicedStrawberries()
	{
		if (currentSlicedStrawberries == 0)
		{

		}
		else if (currentSlicedStrawberries == 1)
		{

		}
		else if (currentSlicedStrawberries == 2)
		{

		}
		else if (currentSlicedStrawberries == 3)
		{

		}
		else if (currentSlicedStrawberries == 4)
		{

		}
		else if (currentSlicedStrawberries >= 5)
		{

		}
	}

	void ShowCurrentIce()
	{
		if (currentIce == 0)
		{

		}
		else if (currentIce == 1)
		{

		}
		else if (currentIce == 2)
		{

		}
		else if (currentIce == 3)
		{

		}
		else if (currentIce == 4)
		{

		}
		else if (currentIce >= 5)
		{

		}
	}
}
