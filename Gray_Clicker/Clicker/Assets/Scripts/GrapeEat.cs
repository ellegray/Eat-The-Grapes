using UnityEngine;
using System.Collections;

public class GrapeEat : MonoBehaviour {

	GameManager gameManager;

	// Use this for initialization
	void Start () {
		//important gameManager script
		GameObject mainGO = GameObject.Find ("MainGameObject");
		gameManager = mainGO.GetComponent<GameManager> ();
	}

	//if grape gets touched by mouse object, destroy it
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "grape(Clone)") 
		{
			gameManager.GrapesEaten++;
			print ("Grapes eaten - " + gameManager.GrapesEaten);

			Destroy(other.gameObject);
		}
	}
}
