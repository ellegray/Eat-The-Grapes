using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GUIStyle myStyle;
	public Texture gameOverTexture;


	//Game over screen with buttons to restart/quit
	void OnGUI()
	{
		GUI.TextField (new Rect (Screen.width /2, Screen.height/2 - 25, 150, 25), "Game Over.", myStyle);

		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gameOverTexture);

		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2, 150, 25),"Try Again")) 
		{
			Application.LoadLevel("mainScene");
		}
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2 + 25, 150, 25),"Exit")) 
		{
			Application.Quit();
		}
	}
}
