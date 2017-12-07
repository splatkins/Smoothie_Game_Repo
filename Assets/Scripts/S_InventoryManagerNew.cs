using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_InventoryManager : MonoBehaviour
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
	public GameObject lemon;
	public GameObject banana;
	public GameObject orange;
	public GameObject strawberry;
	public GameObject ice;

	//peeled ingredients prefabs
	public GameObject peeledLemon;
	public GameObject peeledBanana;
	public GameObject peeledOrange;
	public GameObject peeledStrawberry;

	// sliced ingredients prefabs
	public GameObject lemonSlice;
	public GameObject bananaSlice;
	public GameObject orangeSlice;
	public GameObject strawberrySlice;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// show current whole ingredients
		ShowLemons ();
		ShowStrawberries ();
		ShowBananas ();
		ShowOranges ();

		// display current sliced/peeled ingredients
		ShowSlicedLemons ();
		ShowSlicedStrawberries ();
		ShowPeeledBananas ();
		ShowPeeledOranges ();
	}

	void ShowLemons()
	{
		if (currentLemons == 0)
		{
			lemons1.SetActive(false);
			lemons2.SetActive(false);
			lemons3.SetActive(false);
		}
		else if (currentLemons == 1)
		{
			lemons1.SetActive(true);
			lemons2.SetActive(false);
			lemons3.SetActive(false);
		}
		else if (currentLemons == 2)
		{
			lemons1.SetActive(false);
			lemons2.SetActive(true);
			lemons3.SetActive(false);
		}
		else if (currentLemons >= 3)
		{
			lemons1.SetActive(false);
			lemons2.SetActive(false);
			lemons3.SetActive(true);
		}
	}

	void ShowStrawberries()
	{
		if (currentStrawberries == 0)
		{
			strawberries1.SetActive(false);
			strawberries2.SetActive(false);
			strawberries3.SetActive(false);
		}
		else if (currentStrawberries == 1)
		{
			strawberries1.SetActive(true);
			strawberries2.SetActive(false);
			strawberries3.SetActive(false);
		}
		else if (currentStrawberries == 2)
		{
			strawberries1.SetActive(false);
			strawberries2.SetActive(true);
			strawberries3.SetActive(false);
		}
		else if (currentStrawberries >= 3)
		{
			strawberries1.SetActive(false);
			strawberries2.SetActive(false);
			strawberries3.SetActive(true);
		}
	}

	void ShowBananas()
	{
		if (currentBananas == 0)
		{
			bananas1.SetActive(false);
			bananas2.SetActive(false);
			bananas3.SetActive(false);
		}
		else if (currentBananas == 1)
		{
			bananas1.SetActive(true);
			bananas2.SetActive(false);
			bananas3.SetActive(false);
		}
		else if (currentBananas == 2)
		{
			bananas1.SetActive(false);
			bananas2.SetActive(true);
			bananas3.SetActive(false);
		}
		else if (currentBananas >= 3)
		{
			bananas1.SetActive(false);
			bananas2.SetActive(false);
			bananas3.SetActive(true);
		}
	}

	void ShowOranges()
	{
		if (currentOranges == 0)
		{
			oranges1.SetActive(false);
			oranges2.SetActive(false);
			oranges3.SetActive(false);
		}
		else if (currentOranges == 1)
		{
			oranges1.SetActive(true);
			oranges2.SetActive(false);
			oranges3.SetActive(false);
		}
		else if (currentOranges == 2)
		{
			oranges1.SetActive(false);
			oranges2.SetActive(true);
			oranges3.SetActive(false);
		}
		else if (currentOranges >= 3)
		{
			oranges1.SetActive(false);
			oranges2.SetActive(false);
			oranges3.SetActive(true);
		}
	}

	void ShowSlicedLemons()
	{
		if (currentSlicedLemons == 0)
		{
			slicedLemons1.SetActive(false);
			slicedLemons2.SetActive(false);
			slicedLemons3.SetActive(false);
		}
		else if (currentSlicedLemons == 1)
		{
			slicedLemons1.SetActive(true);
			slicedLemons2.SetActive(false);
			slicedLemons3.SetActive(false);
		}
		else if (currentSlicedLemons == 2)
		{
			slicedLemons1.SetActive(false);
			slicedLemons2.SetActive(true);
			slicedLemons3.SetActive(false);
		}
		else if (currentSlicedLemons >= 3)
		{
			slicedLemons1.SetActive(false);
			slicedLemons2.SetActive(false);
			slicedLemons3.SetActive(true);
		}
	}

	void ShowSlicedStrawberries()
	{
		if (currentSlicedStrawberries == 0)
		{
			slicedStrawberries1.SetActive(false);
			slicedStrawberries2.SetActive(false);
			slicedStrawberries3.SetActive(false);
		}
		else if (currentSlicedStrawberries == 1)
		{
			slicedStrawberries1.SetActive(true);
			slicedStrawberries2.SetActive(false);
			slicedStrawberries3.SetActive(false);
		}
		else if (currentSlicedStrawberries == 2)
		{
			slicedStrawberries1.SetActive(false);
			slicedStrawberries2.SetActive(true);
			slicedStrawberries3.SetActive(false);
		}
		else if (currentSlicedStrawberries >= 3)
		{
			slicedStrawberries1.SetActive(false);
			slicedStrawberries2.SetActive(false);
			slicedStrawberries3.SetActive(true);
		}
	}

	void ShowPeeledBananas()
	{
		if (currentPeeledBananas == 0)
		{
			peeledBananas1.SetActive(false);
			peeledBananas2.SetActive(false);
			peeledBananas3.SetActive(false);
		}
		else if (currentPeeledBananas == 1)
		{
			peeledBananas1.SetActive(true);
			peeledBananas2.SetActive(false);
			peeledBananas3.SetActive(false);
		}
		else if (currentPeeledBananas == 2)
		{
			peeledBananas1.SetActive(false);
			peeledBananas2.SetActive(true);
			peeledBananas3.SetActive(false);
		}
		else if (currentPeeledBananas >= 3)
		{
			peeledBananas1.SetActive(false);
			peeledBananas2.SetActive(false);
			peeledBananas3.SetActive(true);
		}
	}

	void ShowPeeledOranges()
	{
		if (currentPeeledOranges == 0)
		{
			peeledOranges1.SetActive(false);
			peeledOranges2.SetActive(false);
			peeledOranges3.SetActive(false);
		}
		else if (currentPeeledOranges == 1)
		{
			peeledOranges1.SetActive(true);
			peeledOranges2.SetActive(false);
			peeledOranges3.SetActive(false);
		}
		else if (currentPeeledOranges == 2)
		{
			peeledOranges1.SetActive(false);
			peeledOranges2.SetActive(true);
			peeledOranges3.SetActive(false);
		}
		else if (currentPeeledOranges >= 3)
		{
			peeledOranges1.SetActive(false);
			peeledOranges2.SetActive(false);
			peeledOranges3.SetActive(true);
		}
	}
}
