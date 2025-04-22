using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject ball;
	public GameObject titikLontar;
	public float powerLontar;
	public AudioClip ballShootAudio;

	AudioSource ballShootPlayer;
	// Use this for initialization
	void Start () {
		ballShootPlayer = gameObject.AddComponent<AudioSource>();
		ballShootPlayer.clip = ballShootAudio;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject _ball = GameObject.Instantiate(ball,titikLontar.transform.position,titikLontar.transform.rotation);
			_ball.GetComponent<Rigidbody>().AddForce(_ball.transform.forward*powerLontar);
			GameObject.Destroy(_ball,5);

			ballShootPlayer.Play();
		}

		transform.Translate (0,0,Input.GetAxis("Vertical")*speed*Time.deltaTime);
		transform.Rotate (0,Input.GetAxis("Horizontal")*60*Time.deltaTime,0);
	}
}
