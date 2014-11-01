using UnityEngine;
using System.Collections;

public class DestroyAll : MonoBehaviour {

	GameManager gameManager;
	Spawner spawner;
	public int exhausted;
	
	// Use this for initialization
	void Start()
	{
		//keeps track of how many times you've used the 'help' button
		exhausted = 0;
		//important gameManager script
		GameObject mainGO = GameObject.Find ("MainGameObject");
		GameObject secondGO = GameObject.Find ("grapeDrop");
		spawner = secondGO.GetComponent<Spawner> ();
		gameManager = mainGO.GetComponent<GameManager> ();
	}

	void OnGUI()
	{
		//display help button if you've used it under 4 times
		//deletes all grapes
		if (exhausted < 3) 
		{
			if (GUI.Button (new Rect (15, 65, 100, 20), "Help")) 
			{
				Grape[] others = FindObjectsOfType (typeof(Grape)) as Grape[];
				foreach (Grape other in others) 
				{
					Destroy (other.gameObject);
					exhausted += 1;
				}

				for (int i = 0; i < spawner.spots.Count; i++) {
					spawner.spots.RemoveAt(i);
				}
			}
		}
	}
}
