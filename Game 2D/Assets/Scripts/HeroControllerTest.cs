using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroControllerTest : MonoBehaviour
{

    public float moveX = 0f;
    public float runSpeed = 40f;
    public CharacterController2D controller;
    bool jump;


    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }

    }

    void FixedUpdate()
    {
        controller.Move(moveX * Time.fixedDeltaTime, false, jump);
    }
}
