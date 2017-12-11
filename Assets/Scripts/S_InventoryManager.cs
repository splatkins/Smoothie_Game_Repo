using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_InventoryManager : MonoBehaviour
{
	// current whole ingredients
	public int currentLemons = 0, currentBananas = 0, currentOranges = 0, currentStrawberries = 0;

	// current peeled ingredients
	public int currentPeeledLemons = 0, currentPeeledBananas = 0, currentPeeledOranges = 0, currentPeeledStrawberries = 0;

	// current sliced ingredients
	public int currentSlicedLemons = 0, currentSlicedBananas = 0, currentSlicedOranges = 0, currentSlicedStrawberries = 0, currentIce = 0;

	// whole ingredients prefabs
	public GameObject lemon1, lemon2, lemon3, lemon4, lemon5;
	public GameObject banana1, banana2, banana3, banana4, banana5;
	public GameObject orange1, orange2, orange3, orange4, orange5;
	public GameObject strawberry1, strawberry2, strawberry3, strawberry4, strawberry5;

	//peeled ingredients prefabs
	public GameObject lemonPeeled1, lemonPeeled2, lemonPeeled3, lemonPeeled4, lemonPeeled5;
	public GameObject bananaPeeled1, bananaPeeled2, bananaPeeled3, bananaPeeled4, bananaPeeled5;
	public GameObject orangePeeled1, orangePeeled2, orangePeeled3, orangePeeled4, orangePeeled5;
	public GameObject strawberryPeeled1, strawberryPeeled2, strawberryPeeled3, strawberryPeeled4, strawberryPeeled5;

	// sliced ingredients prefabs
	public GameObject lemonSlice1, lemonSlice2, lemonSlice3, lemonSlice4, lemonSlice5, lemonSlice6, lemonSlice7, lemonSlice8, lemonSlice9, lemonSlice10, lemonSlice11, lemonSlice12, lemonSlice13, lemonSlice14, lemonSlice15, lemonSlice16, lemonSlice17, lemonSlice18, lemonSlice19, lemonSlice20, lemonSlice21, lemonSlice22, lemonSlice23, lemonSlice24, lemonSlice25, lemonSlice26, lemonSlice27, lemonSlice28, lemonSlice29, lemonSlice30, lemonSlice31, lemonSlice32, lemonSlice33, lemonSlice34, lemonSlice35;
	public GameObject bananaSlice1, bananaSlice2, bananaSlice3, bananaSlice4, bananaSlice5, bananaSlice6, bananaSlice7, bananaSlice8, bananaSlice9, bananaSlice10, bananaSlice11, bananaSlice12, bananaSlice13, bananaSlice14, bananaSlice15, bananaSlice16, bananaSlice17, bananaSlice18, bananaSlice19, bananaSlice20, bananaSlice21, bananaSlice22, bananaSlice23, bananaSlice24, bananaSlice25, bananaSlice26, bananaSlice27, bananaSlice28, bananaSlice29, bananaSlice30, bananaSlice31, bananaSlice32, bananaSlice33, bananaSlice34, bananaSlice35; 
	public GameObject orangeSlice1, orangeSlice2, orangeSlice3, orangeSlice4, orangeSlice5, orangeSlice6, orangeSlice7, orangeSlice8, orangeSlice9, orangeSlice10, orangeSlice11, orangeSlice12, orangeSlice13, orangeSlice14, orangeSlice15, orangeSlice16, orangeSlice17, orangeSlice18, orangeSlice19, orangeSlice20, orangeSlice21, orangeSlice22, orangeSlice23, orangeSlice24, orangeSlice25;
	public GameObject strawberrySlice1, strawberrySlice2, strawberrySlice3, strawberrySlice4, strawberrySlice5, strawberrySlice6, strawberrySlice7, strawberrySlice8, strawberrySlice9, strawberrySlice10, strawberrySlice11, strawberrySlice12, strawberrySlice13, strawberrySlice14, strawberrySlice15;
	public GameObject ice1, ice2, ice3, ice4, ice5, ice6, ice7, ice8, ice9, ice10, ice11, ice12, ice13, ice14, ice15, ice16, ice17, ice18, ice19, ice20, ice21, ice22, ice23, ice24;

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
		ShowIce ();
	}

	void ShowLemons()
	{
		if (currentLemons <= 0)
		{
			lemon1.SetActive (false); lemon2.SetActive (false); lemon3.SetActive (false); lemon4.SetActive (false); lemon5.SetActive (false);
		}
		else if (currentLemons == 1)
		{
			lemon1.SetActive (true); lemon2.SetActive (false); lemon3.SetActive (false); lemon4.SetActive (false); lemon5.SetActive (false);
		}
		else if (currentLemons == 2)
		{
			lemon1.SetActive (true); lemon2.SetActive (true); lemon3.SetActive (false); lemon4.SetActive (false); lemon5.SetActive (false);
		}
		else if (currentLemons == 3)
		{
			lemon1.SetActive (true); lemon2.SetActive (true); lemon3.SetActive (true); lemon4.SetActive (false); lemon5.SetActive (false);
		}
		else if (currentLemons == 4)
		{
			lemon1.SetActive (true); lemon2.SetActive (true); lemon3.SetActive (true); lemon4.SetActive (true); lemon5.SetActive (false);
		}
		else if (currentLemons >= 5)
		{
			lemon1.SetActive (true); lemon2.SetActive (true); lemon3.SetActive (true); lemon4.SetActive (true); lemon5.SetActive (true);
		}
	}

	void ShowBananas()
	{
		if (currentBananas <= 0)
		{
			banana1.SetActive (false); banana2.SetActive (false); banana3.SetActive (false); banana4.SetActive (false); banana5.SetActive (false);
		}
		else if (currentBananas == 1)
		{
			banana1.SetActive (true); banana2.SetActive (false); banana3.SetActive (false); banana4.SetActive (false); banana5.SetActive (false);
		}
		else if (currentBananas == 2)
		{
			banana1.SetActive (true); banana2.SetActive (true); banana3.SetActive (false); banana4.SetActive (false); banana5.SetActive (false);
		}
		else if (currentBananas == 3)
		{
			banana1.SetActive (true); banana2.SetActive (true); banana3.SetActive (true); banana4.SetActive (false); banana5.SetActive (false);
		}
		else if (currentBananas == 4)
		{
			banana1.SetActive (true); banana2.SetActive (true); banana3.SetActive (true); banana4.SetActive (true); banana5.SetActive (false);
		}
		else if (currentBananas >= 5)
		{
			banana1.SetActive (true); banana2.SetActive (true); banana3.SetActive (true); banana4.SetActive (true); banana5.SetActive (true);
		}
	}

	void ShowOranges()
	{
		if (currentOranges <= 0)
		{
			orange1.SetActive (false); orange2.SetActive (false); orange3.SetActive (false); orange4.SetActive (false); orange5.SetActive (false);
		}
		else if (currentOranges == 1)
		{
			orange1.SetActive (true); orange2.SetActive (false); orange3.SetActive (false); orange4.SetActive (false); orange5.SetActive (false);
		}
		else if (currentOranges == 2)
		{
			orange1.SetActive (true); orange2.SetActive (true); orange3.SetActive (false); orange4.SetActive (false); orange5.SetActive (false);
		}
		else if (currentOranges == 3)
		{
			orange1.SetActive (true); orange2.SetActive (true); orange3.SetActive (true); orange4.SetActive (false); orange5.SetActive (false);
		}
		else if (currentOranges == 4)
		{
			orange1.SetActive (true); orange2.SetActive (true); orange3.SetActive (true); orange4.SetActive (true); orange5.SetActive (false);
		}
		else if (currentOranges >= 5)
		{
			orange1.SetActive (true); orange2.SetActive (true); orange3.SetActive (true); orange4.SetActive (true); orange5.SetActive (true);
		}
	}

	void ShowStrawberries()
	{
		if (currentStrawberries <= 0)
		{
			strawberry1.SetActive (false); strawberry2.SetActive (false); strawberry3.SetActive (false); strawberry4.SetActive (false); strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 1)
		{
			strawberry1.SetActive (true); strawberry2.SetActive (false); strawberry3.SetActive (false); strawberry4.SetActive (false); strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 2)
		{
			strawberry1.SetActive (true); strawberry2.SetActive (true); strawberry3.SetActive (false); strawberry4.SetActive (false); strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 3)
		{
			strawberry1.SetActive (true); strawberry2.SetActive (true); strawberry3.SetActive (true); strawberry4.SetActive (false); strawberry5.SetActive (false);
		}
		else if (currentStrawberries == 4)
		{
			strawberry1.SetActive (true); strawberry2.SetActive (true); strawberry3.SetActive (true); strawberry4.SetActive (true); strawberry5.SetActive (false);
		}
		else if (currentStrawberries >= 5)
		{
			strawberry1.SetActive (true); strawberry2.SetActive (true); strawberry3.SetActive (true); strawberry4.SetActive (true); strawberry5.SetActive (true);
		}
	}

	void ShowPeeledLemons()
	{
		if (currentPeeledLemons <= 0)
		{
			lemonPeeled1.SetActive (false); lemonPeeled2.SetActive (false); lemonPeeled3.SetActive (false); lemonPeeled4.SetActive (false); lemonPeeled5.SetActive (false);
		}
		else if (currentPeeledLemons == 1)
		{
			lemonPeeled1.SetActive (true); lemonPeeled2.SetActive (false); lemonPeeled3.SetActive (false); lemonPeeled4.SetActive (false); lemonPeeled5.SetActive (false);
		}
		else if (currentPeeledLemons == 2)
		{
			lemonPeeled1.SetActive (true); lemonPeeled2.SetActive (true); lemonPeeled3.SetActive (false); lemonPeeled4.SetActive (false); lemonPeeled5.SetActive (false);
		}
		else if (currentPeeledLemons == 3)
		{
			lemonPeeled1.SetActive (true); lemonPeeled2.SetActive (true); lemonPeeled3.SetActive (true); lemonPeeled4.SetActive (false); lemonPeeled5.SetActive (false);
		}
		else if (currentPeeledLemons == 4)
		{
			lemonPeeled1.SetActive (true); lemonPeeled2.SetActive (true); lemonPeeled3.SetActive (true); lemonPeeled4.SetActive (true); lemonPeeled5.SetActive (false);
		}
		else if (currentPeeledLemons >= 5)
		{
			lemonPeeled1.SetActive (true); lemonPeeled2.SetActive (true); lemonPeeled3.SetActive (true); lemonPeeled4.SetActive (true); lemonPeeled5.SetActive (true);
		}
	}

	void ShowPeeledBananas()
	{
		if (currentPeeledBananas <= 0)
		{
			bananaPeeled1.SetActive (false); bananaPeeled2.SetActive (false); bananaPeeled3.SetActive (false); bananaPeeled4.SetActive (false); bananaPeeled5.SetActive (false);
		}
		else if (currentPeeledBananas == 1)
		{
			bananaPeeled1.SetActive (true); bananaPeeled2.SetActive (false); bananaPeeled3.SetActive (false); bananaPeeled4.SetActive (false); bananaPeeled5.SetActive (false);
		}
		else if (currentPeeledBananas == 2)
		{
			bananaPeeled1.SetActive (true); bananaPeeled2.SetActive (true); bananaPeeled3.SetActive (false); bananaPeeled4.SetActive (false); bananaPeeled5.SetActive (false);
		}
		else if (currentPeeledBananas == 3)
		{
			bananaPeeled1.SetActive (true); bananaPeeled2.SetActive (true); bananaPeeled3.SetActive (true); bananaPeeled4.SetActive (false); bananaPeeled5.SetActive (false);
		}
		else if (currentPeeledBananas == 4)
		{
			bananaPeeled1.SetActive (true); bananaPeeled2.SetActive (true); bananaPeeled3.SetActive (true); bananaPeeled4.SetActive (true); bananaPeeled5.SetActive (false);
		}
		else if (currentPeeledBananas >= 5)
		{
			bananaPeeled1.SetActive (true); bananaPeeled2.SetActive (true); bananaPeeled3.SetActive (true); bananaPeeled4.SetActive (true); bananaPeeled5.SetActive (true);
		}
	}

	void ShowPeeledOranges()
	{
		if (currentPeeledOranges <= 0)
		{
			orangePeeled1.SetActive (false); orangePeeled2.SetActive (false); orangePeeled3.SetActive (false); orangePeeled4.SetActive (false); orangePeeled5.SetActive (false);
		}
		else if (currentPeeledOranges == 1)
		{
			orangePeeled1.SetActive (true); orangePeeled2.SetActive (false); orangePeeled3.SetActive (false); orangePeeled4.SetActive (false); orangePeeled5.SetActive (false);		
		}
		else if (currentPeeledOranges == 2)
		{
			orangePeeled1.SetActive (true); orangePeeled2.SetActive (true); orangePeeled3.SetActive (false); orangePeeled4.SetActive (false); orangePeeled5.SetActive (false);		
		}
		else if (currentPeeledOranges == 3)
		{
			orangePeeled1.SetActive (true); orangePeeled2.SetActive (true); orangePeeled3.SetActive (true); orangePeeled4.SetActive (false); orangePeeled5.SetActive (false);		
		}
		else if (currentPeeledOranges == 4)
		{
			orangePeeled1.SetActive (true); orangePeeled2.SetActive (true); orangePeeled3.SetActive (true); orangePeeled4.SetActive (true); orangePeeled5.SetActive (false);	
		}
		else if (currentPeeledOranges >= 5)
		{
			orangePeeled1.SetActive (true); orangePeeled2.SetActive (true); orangePeeled3.SetActive (true); orangePeeled4.SetActive (true); orangePeeled5.SetActive (true);	
		}
	}

	void ShowPeeledStrawberries()
	{
		if (currentPeeledStrawberries == 0)
		{
			strawberryPeeled1.SetActive (false); strawberryPeeled2.SetActive (false); strawberryPeeled3.SetActive (false); strawberryPeeled4.SetActive (false); strawberryPeeled5.SetActive (false); 
		}
		else if (currentPeeledStrawberries == 1)
		{
			strawberryPeeled1.SetActive (true); strawberryPeeled2.SetActive (false); strawberryPeeled3.SetActive (false); strawberryPeeled4.SetActive (false); strawberryPeeled5.SetActive (false); 
		}
		else if (currentPeeledStrawberries == 2)
		{
			strawberryPeeled1.SetActive (true); strawberryPeeled2.SetActive (true); strawberryPeeled3.SetActive (false); strawberryPeeled4.SetActive (false); strawberryPeeled5.SetActive (false); 
		}
		else if (currentPeeledStrawberries == 3)
		{
			strawberryPeeled1.SetActive (true); strawberryPeeled2.SetActive (true); strawberryPeeled3.SetActive (true); strawberryPeeled4.SetActive (false); strawberryPeeled5.SetActive (false); 
		}
		else if (currentPeeledStrawberries == 4)
		{
			strawberryPeeled1.SetActive (true); strawberryPeeled2.SetActive (true); strawberryPeeled3.SetActive (true); strawberryPeeled4.SetActive (true); strawberryPeeled5.SetActive (false); 
		}
		else if (currentPeeledStrawberries >= 5)
		{
			strawberryPeeled1.SetActive (true); strawberryPeeled2.SetActive (true); strawberryPeeled3.SetActive (true); strawberryPeeled4.SetActive (true); strawberryPeeled5.SetActive (true); 
		}
	}
		
	void ShowSlicedLemons()
	{
		if (currentSlicedLemons <= 0)
		{
			lemonSlice1.SetActive (false); lemonSlice2.SetActive (false); lemonSlice3.SetActive (false); lemonSlice4.SetActive (false); lemonSlice5.SetActive (false); lemonSlice6.SetActive (false); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 1)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (false); lemonSlice3.SetActive (false); lemonSlice4.SetActive (false); lemonSlice5.SetActive (false); lemonSlice6.SetActive (false); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 2)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (false); lemonSlice4.SetActive (false); lemonSlice5.SetActive (false); lemonSlice6.SetActive (false); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 3)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (false); lemonSlice5.SetActive (false); lemonSlice6.SetActive (false); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 4)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (false); lemonSlice6.SetActive (false); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 5)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (false); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 6)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (false); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 7)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (false); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 8)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (false); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 9)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (false); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 10)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (false); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 11)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (false); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 12)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (false); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 13)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (false); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 14)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (false); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 15)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (false); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 16)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (false); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 17)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (false); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 18)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (false); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 19)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (false); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 20)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (false); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 21)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (false); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 22)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (false); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 23)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (false); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 24)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (false); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 25)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (false); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 26)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (false); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 27)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (false); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 28)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (false); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 29)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (false); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (false); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 30)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (true); lemonSlice31.SetActive (false); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 31)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (true); lemonSlice31.SetActive (true); lemonSlice32.SetActive (false); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 32)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (true); lemonSlice31.SetActive (true); lemonSlice32.SetActive (true); lemonSlice33.SetActive (false); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 33)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (true); lemonSlice31.SetActive (true); lemonSlice32.SetActive (true); lemonSlice33.SetActive (true); lemonSlice34.SetActive (false); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons == 34)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (true); lemonSlice31.SetActive (true); lemonSlice32.SetActive (true); lemonSlice33.SetActive (true); lemonSlice34.SetActive (true); lemonSlice35.SetActive (false); 
		}
		else if (currentSlicedLemons >= 35)
		{
			lemonSlice1.SetActive (true); lemonSlice2.SetActive (true); lemonSlice3.SetActive (true); lemonSlice4.SetActive (true); lemonSlice5.SetActive (true); lemonSlice6.SetActive (true); lemonSlice7.SetActive (true); lemonSlice8.SetActive (true); lemonSlice9.SetActive (true); lemonSlice10.SetActive (true); lemonSlice11.SetActive (true); lemonSlice12.SetActive (true); lemonSlice13.SetActive (true); lemonSlice14.SetActive (true); lemonSlice15.SetActive (true); lemonSlice16.SetActive (true); lemonSlice17.SetActive (true); lemonSlice18.SetActive (true); lemonSlice19.SetActive (true); lemonSlice20.SetActive (true); lemonSlice21.SetActive (true); lemonSlice22.SetActive (true); lemonSlice23.SetActive (true); lemonSlice24.SetActive (true); lemonSlice25.SetActive (true); lemonSlice26.SetActive (true); lemonSlice27.SetActive (true); lemonSlice28.SetActive (true); lemonSlice29.SetActive (true); lemonSlice30.SetActive (true); lemonSlice31.SetActive (true); lemonSlice32.SetActive (true); lemonSlice33.SetActive (true); lemonSlice34.SetActive (true); lemonSlice35.SetActive (true); 
		}
	}

	void ShowSlicedBananas()
	{
		if (currentSlicedBananas <= 0)
		{
			bananaSlice1.SetActive (false); bananaSlice2.SetActive (false); bananaSlice3.SetActive (false); bananaSlice4.SetActive (false); bananaSlice5.SetActive (false); bananaSlice6.SetActive (false); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 1)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (false); bananaSlice3.SetActive (false); bananaSlice4.SetActive (false); bananaSlice5.SetActive (false); bananaSlice6.SetActive (false); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 2)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (false); bananaSlice4.SetActive (false); bananaSlice5.SetActive (false); bananaSlice6.SetActive (false); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 3)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (false); bananaSlice5.SetActive (false); bananaSlice6.SetActive (false); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 4)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (false); bananaSlice6.SetActive (false); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 5)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (false); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 6)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (false); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 7)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (false); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 8)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (false); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 9)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (false); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 10)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (false); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 11)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (false); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 12)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (false); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 13)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (false); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 14)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (false); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 15)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (false); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 16)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (false); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 17)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (false); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 18)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (false); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 19)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (false); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 20)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (false); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 21)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (false); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 22)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (false); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 23)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (false); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 24)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (false); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 25)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (false); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 26)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (false); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 27)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (false); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 28)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (false); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 29)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (false); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 30)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (true); bananaSlice31.SetActive (false); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 31)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (true); bananaSlice31.SetActive (true); bananaSlice32.SetActive (false); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 32)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (true); bananaSlice31.SetActive (true); bananaSlice32.SetActive (true); bananaSlice33.SetActive (false); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 33)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (true); bananaSlice31.SetActive (true); bananaSlice32.SetActive (true); bananaSlice33.SetActive (true); bananaSlice34.SetActive (false); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas == 34)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (true); bananaSlice31.SetActive (true); bananaSlice32.SetActive (true); bananaSlice33.SetActive (true); bananaSlice34.SetActive (true); bananaSlice35.SetActive (false); 
		}
		else if (currentSlicedBananas >= 35)
		{
			bananaSlice1.SetActive (true); bananaSlice2.SetActive (true); bananaSlice3.SetActive (true); bananaSlice4.SetActive (true); bananaSlice5.SetActive (true); bananaSlice6.SetActive (true); bananaSlice7.SetActive (true); bananaSlice8.SetActive (true); bananaSlice9.SetActive (true); bananaSlice10.SetActive (true); bananaSlice11.SetActive (true); bananaSlice12.SetActive (true); bananaSlice13.SetActive (true); bananaSlice14.SetActive (true); bananaSlice15.SetActive (true); bananaSlice16.SetActive (true); bananaSlice17.SetActive (true); bananaSlice18.SetActive (true); bananaSlice19.SetActive (true); bananaSlice20.SetActive (true); bananaSlice21.SetActive (true); bananaSlice22.SetActive (true); bananaSlice23.SetActive (true); bananaSlice24.SetActive (true); bananaSlice25.SetActive (true); bananaSlice26.SetActive (true); bananaSlice27.SetActive (true); bananaSlice28.SetActive (true); bananaSlice29.SetActive (true); bananaSlice30.SetActive (true); bananaSlice31.SetActive (true); bananaSlice32.SetActive (true); bananaSlice33.SetActive (true); bananaSlice34.SetActive (true); bananaSlice35.SetActive (true); 
		}
	}

	void ShowSlicedOranges()
	{
		if (currentSlicedOranges <= 0)
		{
			orangeSlice1.SetActive (false); orangeSlice2.SetActive (false); orangeSlice3.SetActive (false); orangeSlice4.SetActive (false); orangeSlice5.SetActive (false); orangeSlice6.SetActive (false); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 1)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (false); orangeSlice3.SetActive (false); orangeSlice4.SetActive (false); orangeSlice5.SetActive (false); orangeSlice6.SetActive (false); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 2)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (false); orangeSlice4.SetActive (false); orangeSlice5.SetActive (false); orangeSlice6.SetActive (false); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 3)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (false); orangeSlice5.SetActive (false); orangeSlice6.SetActive (false); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 4)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (false); orangeSlice6.SetActive (false); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 5)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (false); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 6)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (false); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 7)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (false); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 8)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (false); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 9)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (false); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 10)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (false); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 11)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (false); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 12)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (false); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 13)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (false); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false); 
		}
		else if (currentSlicedOranges == 14)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (false); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 15)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (false); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 16)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (false); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 17)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (false); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 18)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (false); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false); 
		}
		else if (currentSlicedOranges == 19)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (false); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 20)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (true); orangeSlice21.SetActive (false); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 21)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (true); orangeSlice21.SetActive (true); orangeSlice22.SetActive (false); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 22)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (true); orangeSlice21.SetActive (true); orangeSlice22.SetActive (true); orangeSlice23.SetActive (false); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 23)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (true); orangeSlice21.SetActive (true); orangeSlice22.SetActive (true); orangeSlice23.SetActive (true); orangeSlice24.SetActive (false); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 24)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (true); orangeSlice21.SetActive (true); orangeSlice22.SetActive (true); orangeSlice23.SetActive (true); orangeSlice24.SetActive (true); orangeSlice25.SetActive (false);
		}
		else if (currentSlicedOranges == 25)
		{
			orangeSlice1.SetActive (true); orangeSlice2.SetActive (true); orangeSlice3.SetActive (true); orangeSlice4.SetActive (true); orangeSlice5.SetActive (true); orangeSlice6.SetActive (true); orangeSlice7.SetActive (true); orangeSlice8.SetActive (true); orangeSlice9.SetActive (true); orangeSlice10.SetActive (true); orangeSlice11.SetActive (true); orangeSlice12.SetActive (true); orangeSlice13.SetActive (true); orangeSlice14.SetActive (true); orangeSlice15.SetActive (true); orangeSlice16.SetActive (true); orangeSlice17.SetActive (true); orangeSlice18.SetActive (true); orangeSlice19.SetActive (true); orangeSlice20.SetActive (true); orangeSlice21.SetActive (true); orangeSlice22.SetActive (true); orangeSlice23.SetActive (true); orangeSlice24.SetActive (true); orangeSlice25.SetActive (true);
		}
	}

	void ShowSlicedStrawberries()
	{
		if (currentSlicedStrawberries <= 0)
		{
			strawberrySlice1.SetActive (false); strawberrySlice2.SetActive (false); strawberrySlice3.SetActive (false); strawberrySlice4.SetActive (false); strawberrySlice5.SetActive (false); strawberrySlice6.SetActive (false); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 1)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (false); strawberrySlice3.SetActive (false); strawberrySlice4.SetActive (false); strawberrySlice5.SetActive (false); strawberrySlice6.SetActive (false); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 2)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (false); strawberrySlice4.SetActive (false); strawberrySlice5.SetActive (false); strawberrySlice6.SetActive (false); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 3)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (false); strawberrySlice5.SetActive (false); strawberrySlice6.SetActive (false); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 4)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (false); strawberrySlice6.SetActive (false); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 5)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (false); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 6)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (false); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 7)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (false); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 8)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (false); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 9)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (false); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 10)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (true); strawberrySlice11.SetActive (false); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 11)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (true); strawberrySlice11.SetActive (true); strawberrySlice12.SetActive (false); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 12)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (true); strawberrySlice11.SetActive (true); strawberrySlice12.SetActive (true); strawberrySlice13.SetActive (false); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 13)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (true); strawberrySlice11.SetActive (true); strawberrySlice12.SetActive (true); strawberrySlice13.SetActive (true); strawberrySlice14.SetActive (false); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 14)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (true); strawberrySlice11.SetActive (true); strawberrySlice12.SetActive (true); strawberrySlice13.SetActive (true); strawberrySlice14.SetActive (true); strawberrySlice15.SetActive (false);
		}
		else if (currentSlicedStrawberries == 15)
		{
			strawberrySlice1.SetActive (true); strawberrySlice2.SetActive (true); strawberrySlice3.SetActive (true); strawberrySlice4.SetActive (true); strawberrySlice5.SetActive (true); strawberrySlice6.SetActive (true); strawberrySlice7.SetActive (true); strawberrySlice8.SetActive (true); strawberrySlice9.SetActive (true); strawberrySlice10.SetActive (true); strawberrySlice11.SetActive (true); strawberrySlice12.SetActive (true); strawberrySlice13.SetActive (true); strawberrySlice14.SetActive (true); strawberrySlice15.SetActive (true);
		}
	}

	void ShowIce()
	{
		if (currentIce <= 0)
		{
			ice1.SetActive (false); ice2.SetActive (false); ice3.SetActive (false); ice4.SetActive (false); ice5.SetActive (false); ice6.SetActive (false); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 1)
		{
			ice1.SetActive (true); ice2.SetActive (false); ice3.SetActive (false); ice4.SetActive (false); ice5.SetActive (false); ice6.SetActive (false); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 2)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (false); ice4.SetActive (false); ice5.SetActive (false); ice6.SetActive (false); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 3)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (false); ice5.SetActive (false); ice6.SetActive (false); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 4)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (false); ice6.SetActive (false); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 5)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (false); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 6)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (false); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 7)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (false); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 8)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (false); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 9)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (false); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 10)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (false); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false); 
		}
		else if (currentIce == 11)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (false); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 12)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (false); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 13)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (false); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 14)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (false); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 15)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (false); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 16)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (false); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 17)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (false); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 18)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (false); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 19)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (true); ice20.SetActive (false); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 20)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (true); ice20.SetActive (true); ice21.SetActive (false); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 21)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (true); ice20.SetActive (true); ice21.SetActive (true); ice22.SetActive (false); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 22)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (true); ice20.SetActive (true); ice21.SetActive (true); ice22.SetActive (true); ice23.SetActive (false); ice24.SetActive (false);
		}
		else if (currentIce == 23)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (true); ice20.SetActive (true); ice21.SetActive (true); ice22.SetActive (true); ice23.SetActive (true); ice24.SetActive (false);
		}
		else if (currentIce == 24)
		{
			ice1.SetActive (true); ice2.SetActive (true); ice3.SetActive (true); ice4.SetActive (true); ice5.SetActive (true); ice6.SetActive (true); ice7.SetActive (true); ice8.SetActive (true); ice9.SetActive (true); ice10.SetActive (true); ice11.SetActive (true); ice12.SetActive (true); ice13.SetActive (true); ice14.SetActive (true); ice15.SetActive (true); ice16.SetActive (true); ice17.SetActive (true); ice18.SetActive (true); ice19.SetActive (true); ice20.SetActive (true); ice21.SetActive (true); ice22.SetActive (true); ice23.SetActive (true); ice24.SetActive (true);
		}
	}
}
