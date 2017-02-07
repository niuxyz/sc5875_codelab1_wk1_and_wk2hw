using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followscript : MonoBehaviour {
	public Transform playerpos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	transform.position = playerpos.position;
		
	}
}
