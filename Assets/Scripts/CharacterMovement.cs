using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	public CharacterController2D controller;
	public Animator animator;
	
    public float runSpeed = 40f;
	bool jump = false;
	bool crouch= false;
	AudioSource audioSrc;
	bool isMoving = false;
	float horizontalMove = 0f;
	Rigidbody2D rb;

    // Update is called once per frame
	
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		audioSrc = GetComponent<AudioSource> ();
	}
	
    void Update()
    {
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			
			animator.SetFloat("Speeds", Mathf.Abs(horizontalMove));
			
			
			if (rb.velocity.x !=0)
				isMoving = true;
			else
				isMoving = false;
			if (isMoving) {
				if (!audioSrc.isPlaying)
					audioSrc.Play ();
			}
			else
				audioSrc.Stop ();
			
			if (Input.GetButtonDown("Jump"))
			{
				jump = true;
				animator.SetBool("IsJumping", true);
			}
			
			if (Input.GetButtonDown("Crouch"))
			{
				crouch = true;
			} else if (Input.GetButtonUp("Crouch"))
			{
				crouch = false;
			}
    }
	
	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}
	
	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}
	
	
	void FixedUpdate ()
	{
		controller.Move(horizontalMove* Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
