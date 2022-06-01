using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
	private Animator anim;
	public Slider healthBar;
	public bool isDead;
	public Transform player;
	
	[SerializeField] float health, maxHealth = 50f;
	
	public bool isFlipped = false;
	
	private void Start()
	{
		health = maxHealth;
	}

	public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;

		if (transform.position.x > player.position.x && isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;
		}
		else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
		}
	}
	
	public void TakeDamage(float damageAmount)
	{
		health -= damageAmount;
		
		if(health <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	private void Update()
    {

        if (health <= 25) {
            anim.SetTrigger("IsEnraged");
        }

        if (health <= 0) {
            anim.SetTrigger("death");
        }
	}


}