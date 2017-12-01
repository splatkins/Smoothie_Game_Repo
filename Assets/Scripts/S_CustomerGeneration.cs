using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CustomerGeneration : MonoBehaviour
{
	// list of female heads
	public List<SpriteRenderer> femaleHeads = new List<SpriteRenderer>();

	// list of female heads
	public List<Sprite> maleHeads = new List<Sprite>();

	// list of female bodies
	public List<Sprite> femaleBodies = new List<Sprite>();

	// list of male bodies
	public List<Sprite> maleBodies = new List<Sprite>();

	public SpriteRenderer myHead;

	// Use this for initialization
	void Start ()
	{
		MaleOrFemale ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void MaleOrFemale ()
	{
		//myHead = gameObject.GetComponent<Sprite> ();

		int maleOrFemale = Random.Range(0, 10); // 0, 1, 2, 3, 4 = male, 5, 6, 7, 8, 9 = female

		if (maleOrFemale <= 4)
		{
			int randomHead = Random.Range (0, 2);

			if (randomHead == 0)
			{
				myHead = femaleHeads [0].sprite;
			}
			else if (randomHead == 1)
			{
				myHead.sprite = femaleHeads [1].sprite;
			}
			else if (randomHead == 2)
			{
				myHead.sprite = femaleHeads [2].sprite;
			}
		}
		else if(maleOrFemale >= 5)
		{

		}

	}
}
