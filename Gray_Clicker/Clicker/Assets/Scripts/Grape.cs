using UnityEngine;
using System.Collections;

public class Grape : MonoBehaviour {

	public int index;
	public Vector3[] roll;
	public bool rolling;
	
	GameManager gameManager;
	// Use this for initialization
	void Start () {
		//important gameManager script
		GameObject mainGO = GameObject.Find ("MainGameObject");
		gameManager = mainGO.GetComponent<GameManager> ();

		rolling = true;
		StartCoroutine (StopRolling ());
		StartCoroutine (DestroyMyself ());

		//vectors to randomly pick roll direction
		roll = new Vector3[5];
		roll [0] = Vector3.left * Time.deltaTime;
		roll [1] = Vector3.right * Time.deltaTime;
		roll [2] = Vector3.up * Time.deltaTime;
		roll [3] = Vector3.down * Time.deltaTime;
		index = Random.Range (0, 3);
	}

	//makes grape roll for a second when initially 'dropped'
	IEnumerator StopRolling()
	{
		yield return new WaitForSeconds (1);
		rolling = false;
	}

	//grape destroys itself if not eaten by mouse after 5 seconds
	IEnumerator DestroyMyself()
	{
		yield return new WaitForSeconds (5);
		gameManager.GrapesPickedUp++;
		print ("Grapes Picked Up: " + gameManager.GrapesPickedUp);
		Destroy (gameObject);

		//if you miss three grapes, game is over
		if(gameManager.GrapesPickedUp == 3)
		{
			gameManager.over = true;
			Application.LoadLevel("gameOver");
			Application.Quit ();
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		//makes grape roll
		if (rolling) 
		{
			transform.position += roll [index];
			float spinRate = 1f;
			transform.Rotate (0, 0, spinRate);
		}
	}
}
