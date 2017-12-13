using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CustomerGeneration : MonoBehaviour
{
	// list of female heads
	public List<Sprite> femaleHeads = new List<Sprite>();
	public List<Sprite> femaleHappyHeads = new List<Sprite>();

	// list of male heads
	public List<Sprite> maleHeads = new List<Sprite>();
	public List<Sprite> maleHappyHeads = new List<Sprite>();

	// list of female bodies
	public List<Sprite> femaleBodies = new List<Sprite>();

	// list of male bodies
	public List<Sprite> maleBodies = new List<Sprite>();

	// list of drink requests
	public List<Sprite> drinkRequests = new List<Sprite>();

	public string myRequest = "nothing";
	public bool happy;

	// Use this for initialization
	void Start ()
	{
		MaleOrFemale ();
	}
	
	// Update is called once per frame
//	void Update ()
//	{
//		
//	}

	void MaleOrFemale ()
	{
		int maleOrFemale = Random.Range(0, 10); // 0, 1, 2, 3, 4 = male, 5, 6, 7, 8, 9 = female

		if (maleOrFemale <= 4) // female
		{
			// head
			int randomHead = Random.Range (0, 3);

			//print ("female head " + (randomHead + 1));

			if (randomHead == 0)
			{
				this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHeads [0];
				//GameObject.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHeads [0];
			}
			else if (randomHead == 1)
			{
				this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHeads [1];
			}
			else if (randomHead == 2)
			{
				this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHeads [2];
			}

			// body
			int randomBody = Random.Range (0, 3);

		//	print ("female body " + (randomHead + 1) + " female head " + (randomBody + 1));

			if (randomBody == 0)
			{
				this.transform.Find ("Body").GetComponentInChildren<SpriteRenderer> ().sprite = femaleBodies [0];
			}
			else if (randomBody == 1)
			{
				this.transform.Find ("Body").GetComponentInChildren<SpriteRenderer> ().sprite = femaleBodies [1];
			}
			else if (randomBody == 2)
			{
				this.transform.Find ("Body").GetComponentInChildren<SpriteRenderer> ().sprite = femaleBodies [2];
			}
		}
		else if(maleOrFemale >= 5) // male
		{
			// head
			int randomHead = Random.Range (0, 3);

			//print ("male head " + (randomHead+1));

			if (randomHead == 0)
			{
				this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = maleHeads [0];
			}
			else if (randomHead == 1)
			{
				this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = maleHeads [1];
			}
			else if (randomHead == 2)
			{
				this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = maleHeads [2];
			}

			// body
			int randomBody = Random.Range (0, 3);

		//	print ("male body " + (randomHead + 1) + " male head " + (randomBody + 1));

			if (randomBody == 0)
			{
				this.transform.Find ("Body").GetComponentInChildren<SpriteRenderer> ().sprite = maleBodies [0];
			}
			else if (randomBody == 1)
			{
				this.transform.Find ("Body").GetComponentInChildren<SpriteRenderer> ().sprite = maleBodies [1];
			}
			else if (randomBody == 2)
			{
				this.transform.Find ("Body").GetComponentInChildren<SpriteRenderer> ().sprite = maleBodies [2];
			}
		}

	}

	public void MakeRquest()
	{
		int randomDrinkRequest = Random.Range (0, 6);

		if (randomDrinkRequest == 0)
		{
			// Lemon twist
			this.transform.Find("Request").GetComponentInChildren<SpriteRenderer>().sprite = drinkRequests[0];
			myRequest = "Lemon Twist";
		}
		else if (randomDrinkRequest == 1)
		{
			// Orange crush
			this.transform.Find("Request").GetComponentInChildren<SpriteRenderer>().sprite = drinkRequests[1];
			myRequest = "Orange Crush";
		}
		else if (randomDrinkRequest == 2)
		{
			// Citrus burst
			this.transform.Find("Request").GetComponentInChildren<SpriteRenderer>().sprite = drinkRequests[2];
			myRequest = "Citrus Burst";
		}
		else if (randomDrinkRequest == 3)
		{
			// Banana banter
			this.transform.Find("Request").GetComponentInChildren<SpriteRenderer>().sprite = drinkRequests[3];
			myRequest = "Banana Banter";
		}
		else if (randomDrinkRequest == 4)
		{
			// Berry bliss
			this.transform.Find("Request").GetComponentInChildren<SpriteRenderer>().sprite = drinkRequests[4];
			myRequest = "Berry Bliss";
		}
		else if (randomDrinkRequest == 5)
		{
			// Abomination
			this.transform.Find("Request").GetComponentInChildren<SpriteRenderer>().sprite = drinkRequests[5];
			myRequest = "Abomination";
		}
	}

	public void HappyCustomer()
	{
		if (this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite == femaleHeads [0])
		{
			this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHappyHeads [0];
		}

		if (this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite == femaleHeads [1])
		{
			this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHappyHeads [1];
		}

		if (this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite == femaleHeads [2])
		{
			this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = femaleHappyHeads [2];
		}

		if (this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite == maleHeads [0])
		{
			this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = maleHappyHeads [0];
		}

		if (this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite == maleHeads [1])
		{
			this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = maleHappyHeads [1];
		}

		if (this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite == maleHeads [2])
		{
			this.transform.Find ("Head").GetComponentInChildren<SpriteRenderer> ().sprite = maleHappyHeads [2];
		}

		happy = true;
	}
}
