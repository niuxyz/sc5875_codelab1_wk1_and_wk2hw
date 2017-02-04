using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

	public float Maxspeed;
	public string cntrlx;
	public string cntrly;

	//The Direction and Speed Information
	private Vector2 velocity;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	void Move(){
		Vector2 targetVelocity = new Vector2(Input.GetAxis(cntrlx), Input.GetAxis(cntrly))*Maxspeed;
		velocity = Vector2.Lerp(velocity, targetVelocity, 0.1f);
		GetComponent<Rigidbody2D>().velocity = velocity;

		Color playerColor = new Color(1,1,1,velocity.magnitude/Maxspeed);
		GetComponent<SpriteRenderer>().color =  playerColor;
	}
}
