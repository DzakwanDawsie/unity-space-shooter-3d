using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour {

	public GameObject particle;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		

		if(animator.GetCurrentAnimatorStateInfo(0).IsName("Destroy")){
			Score.score++;
			PlayerHealth.currentHealth += 10;
			Destroy(gameObject);
			GameObject p = GameObject.Instantiate(particle,transform.position,transform.rotation);
			Destroy(p,1);
			AIEnemyController.speed = 2f;
			
		}
		
	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag.Equals("Bullet"))
		{
			AIEnemyController.speed = 0f;
			animator.SetBool("IsDead",true);
		}
	}
}
