using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    private Animator playerAnimation;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public float strengthOfJump = 10;
    private bool isOnGround = false;
    public bool isGameOver = false;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        playerAnimation = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
            {
                Jump();
            }
            else
            {
                dirtParticle.Play();
            }
        }  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
        
    }

    void Jump()
    {
        playerRigidBody.AddForce(Vector3.up * strengthOfJump, ForceMode.Impulse);
        playerAnimation.SetTrigger("Jump_trig");
        isOnGround = false;
        dirtParticle.Stop();
        playerAudio.PlayOneShot(jumpSound, 1.0f);
    }
    void Die()
    {
        isGameOver = true;
        playerAnimation.SetInteger("DeathType_int", 1);
        playerAnimation.SetBool("Death_b", true);
        explosionParticle.Play();
        dirtParticle.Stop();
        playerAudio.PlayOneShot(crashSound, 1.0f);
    }
}
