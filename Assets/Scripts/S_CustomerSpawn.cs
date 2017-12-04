using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CustomerSpawn : MonoBehaviour
{
	public GameObject customer;
	public int numberOfCustomers;
	int currentCustomers;

	public List<Vector3> customerSpawnPoints = new List<Vector3> ();

	bool spawn6InUse, spawn5InUse, spawn4InUse, spawn3InUse, spawn2InUse, spawn1InUse;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		int randomSpawnPoint = Random.Range (0, 7);
		Vector3 spawnPoint = new Vector3();

		if (currentCustomers < numberOfCustomers)
		{
			switch (randomSpawnPoint)
			{

			case 5:
				if (spawn6InUse == true)
				{
					break;
				}
				spawnPoint = customerSpawnPoints [5];
				spawn6InUse = true;
				Instantiate (customer, spawnPoint, Quaternion.identity, GameObject.Find ("Environment").GetComponent<Transform>());
				currentCustomers++;
				break;
			case 4:
				if (spawn5InUse == true)
				{
					break;
				}
				spawnPoint = customerSpawnPoints [4];
				spawn5InUse = true;
				Instantiate (customer, spawnPoint, Quaternion.identity, GameObject.Find ("Environment").GetComponent<Transform>());
				currentCustomers++;
				break;
			case 3:
				if (spawn4InUse == true)
				{
					break;
				}
				spawnPoint = customerSpawnPoints [3];
				spawn4InUse = true;
				Instantiate (customer, spawnPoint, Quaternion.identity, GameObject.Find ("Environment").GetComponent<Transform>());
				currentCustomers++;
				break;
			case 2:
				if (spawn3InUse == true)
				{
					break;
				}
				spawnPoint = customerSpawnPoints [2];
				spawn3InUse = true;
				Instantiate (customer, spawnPoint, Quaternion.identity, GameObject.Find ("Environment").GetComponent<Transform>());
				currentCustomers++;
				break;
			case 1:
				if (spawn2InUse == true)
				{
					break;
				}
				spawnPoint = customerSpawnPoints [1];
				spawn2InUse = true;
				Instantiate (customer, spawnPoint, Quaternion.identity, GameObject.Find ("Environment").GetComponent<Transform>());
				currentCustomers++;
				break;
			case 0:
				if (spawn1InUse == true)
				{
					break;
				}
				spawnPoint = customerSpawnPoints [0];
				spawn1InUse = true;
				Instantiate (customer, spawnPoint, Quaternion.identity, GameObject.Find ("Environment").GetComponent<Transform>());
				currentCustomers++;
				break;
			default:
				//print ("Customer did not spawn");
				break;
			}
				
			//print ("spawn point " + spawnPoint);
		}
	}
}
