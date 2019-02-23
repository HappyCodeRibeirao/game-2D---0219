using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heroController : MonoBehaviour {


    public CharacterController2D moveController;
    public float velocidade;
    public Animator animator;

    public Sprite[] hearts;
    public Image lifeHud;

    int heart = 1;

    

    private void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            moveController.Move(0, false, true);
            animator.SetBool("isJumping",true);
        }
        else
        {
            animator.SetBool("isJumping",false);
        }

        if (Input.GetKey("right"))
        {
            moveController.Move(1 * velocidade, false, false);
            animator.SetBool("isRunning",true);
            
        }
        else
        {
            
            if (Input.GetKey("left"))
            {
                moveController.Move(-1 * velocidade, false, false);
                animator.SetBool("isRunning",true);
                
            }
            else
            {
                animator.SetBool("isRunning",false);
                moveController.Move(0, false, false);
            }
        }
        
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.gameObject.tag == "Inimigo")
        {
            heart++;
            
            if (heart > hearts.Length)
            {
                Destroy(gameObject);
                return;
            }

            lifeHud.sprite = hearts[heart - 1];
        }
    }

}


