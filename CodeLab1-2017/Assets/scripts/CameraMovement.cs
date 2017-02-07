using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	[SerializeField] GameObject[] players;
	[SerializeField] float sizeChange;
	[SerializeField] Vector2 sizeRange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = MidPoint();
		changeSize(getMaxDistance());
	}

	//Return the midPoint of the Player 
	protected Vector3 MidPoint()
	{
		Vector3 tempPos = Vector3.back * 10;
		for(int i = 0; i < players.Length; i++)
		{
			tempPos += players[i].transform.position;
		}

		tempPos = tempPos/players.Length;
		tempPos.z = -10.0f;

		return tempPos;
	}

	protected float getMaxDistance()
	{
		float widthDivation = 0.0f;
		float heightDivation = 0.0f;
		float MaxDivation = 0.0f;

		widthDivation = players[1].transform.position.x - players[0].transform.position.x;
		heightDivation = players[1].transform.position.y - players[0].transform.position.y;

		heightDivation = Mathf.Abs(heightDivation);
		widthDivation = Mathf.Abs(widthDivation);

		// if(heightDivation >= widthDivation)
		// {
		// 	MaxDivation = heightDivation;
		// }
		// else
		// 	MaxDivation = widthDivation;

		MaxDivation = Mathf.Max(heightDivation/Screen.height,widthDivation/Screen.width);

		return MaxDivation;
	}

	protected void changeSize(float Divation)
	{
		float tempSize = 0.0f;

		tempSize = Divation * Screen.width/ sizeChange;
		if(tempSize <= sizeRange.x)
		{
			tempSize = sizeRange.x;
		}
		if(tempSize >= sizeRange.y)
		{
			tempSize = sizeRange.y;
		}

		//Camera.main.orthographicSize = Divation * Screen.width/ sizeChange;
		Camera.main.orthographicSize = tempSize;
	}
}
