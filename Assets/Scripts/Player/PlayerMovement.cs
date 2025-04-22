using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 12f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,0,Input.GetAxis("Vertical")*speed*Time.deltaTime);
		transform.Rotate (0,Input.GetAxis("Horizontal")*60*Time.deltaTime,0);
	}
}
