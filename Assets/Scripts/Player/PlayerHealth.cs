using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public static int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public AudioClip enemyHitAudio;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f , 0f , 0f , 0.1f);



	// PlayerShooting playerShooting;
	bool isDead;
	bool damaged;

	int attackdamage = 5;

	public static bool gameStart = false;

	AudioSource enemyHitPlayer;

	// Use this for initialization
	void Awake () {
		// playerShooting = GetComponentInChildren <PlayerShooting> ();
		currentHealth = startingHealth;
		gameStart = true;
		enemyHitPlayer = gameObject.AddComponent<AudioSource>();
		enemyHitPlayer.clip = enemyHitAudio;
	}
	
	// Update is called once per frame
	void Update () {

		


		if (damaged)
		{
			currentHealth -= attackdamage;
			damageImage.color = flashColour;
			
			
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color , Color.clear , flashSpeed * Time.deltaTime);
		}

		healthSlider.value = currentHealth;
		damaged = false;	
		
	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag.Equals("Enemy"))
		{
			damaged = true;
			enemyHitPlayer.Play();
		}
	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionExit(Collision other)
	{
		if(other.gameObject.tag.Equals("Enemy"))
		{
			damaged = false;
		}
	}
}
