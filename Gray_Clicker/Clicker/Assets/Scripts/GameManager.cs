using UnityEngine;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

public class GameManager : MonoBehaviour {
	
	public bool over;
	public GUIStyle myStyle;
	private int grapesEaten;
	private int grapesPickedUp;
	public int GrapesEaten { get; set; }
	public int GrapesPickedUp {get; set;}

	// Use this for initialization
	void Start () {
		over = false;
		grapesEaten = 0;
		grapesPickedUp = 0;
	}
	
	// Update is called once per frame
	//display
	void OnGUI () {
		//displays how many grapes have been eaten and how many have been missed on screen
		if (over == false) 
		{
			GUI.TextField (new Rect (20, 20, 200, 30), "Eaten: " + GrapesEaten, myStyle);
			GUI.TextField (new Rect (20, 40, 200, 30), "Missed: " + GrapesPickedUp, myStyle);
		}

	}
}
