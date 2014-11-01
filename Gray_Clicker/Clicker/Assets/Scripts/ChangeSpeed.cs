using UnityEngine;
using System.Collections;

public class ChangeSpeed : MonoBehaviour {

	public GameObject Mouse;
	public float changeSpeed;

	//changes speed of mouse when it hits a 'spill'
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == Mouse) 
		{
			MoveScript traveller = other.GetComponent<MoveScript>();
			traveller.speed = changeSpeed;
		}
	}

}
