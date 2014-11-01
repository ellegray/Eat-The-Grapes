using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Spawner : MonoBehaviour {
	public float spawnDelay = 3;
	public float newDestroy = 3;
	public GameObject grape;
	public Transform grapeDrop;
	public List <Rect> spots = new List<Rect> ();

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn()
	{
		//infinite loop
		while (true) 
		{
			//pick random value for position of grape
			float randomX = Random.Range (-20f, 20f);
			float randomY = Random.Range (-11f, 11f);
			Rect test = new Rect (randomX - 1.9f / 2, randomY - 1.90f / 2, 1.90f, 1.90f);

			//wait before spawning
			yield return new WaitForSeconds (spawnDelay);

			//if no overlap, create the grape and add it to the list
			if (overlapCheck (test)) 
			{
				spots.Add (test);
				grapeDrop.position = new Vector3 (randomX, randomY, 0);
				GameObject clone = Instantiate (grape, grapeDrop.position, transform.rotation) as GameObject;
			}
	
			//decrease the spawn delay
			if (spawnDelay > 0.9) 
			{
				spawnDelay -= 0.1f ;
			}
		}
	}

	//checking for grape rectangle overlap
	//if overlapping, return false and restart the process
	bool overlapCheck(Rect newPos)
	{
		bool allGood = false;

		if (spots.Count == 0) 
		{
			allGood = true;
		}
		//if no overlap, return that you're all good
		else 
		{
			for (int i = 0; i < spots.Count; i++) 
			{
				bool overlapping = newPos.Overlaps(spots[i]);
			
				if (overlapping)
				{
					i = spots.Count;
					allGood = false;
				}
				else
				{
					allGood = true;
				}
			}
		}
		return allGood;
	}
}
