using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float speed = 12;
	public float rotate = 4;

	// Use this for initialization
	void Start () {
	}

	//allows mouse to rotate and move
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
				transform.Translate (-speed * Time.deltaTime, 0f, 0f);
		}
	
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
				transform.Translate (speed * Time.deltaTime, 0f, 0f);
		}
	
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
				transform.Rotate (0, 0, -rotate);
		}
	
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
				transform.Rotate (0, 0, rotate);
		}
	
	}
}
