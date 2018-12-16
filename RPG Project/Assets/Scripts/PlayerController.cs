﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Animator playerAnimator;
    private bool playerMoving;
    private Vector2 lastMove;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        playerAnimator.SetFloat("Move X", Input.GetAxisRaw("Horizontal"));
        playerAnimator.SetFloat("Move Y", Input.GetAxisRaw("Vertical"));

        playerAnimator.SetBool("Player Moving", playerMoving);
        playerAnimator.SetFloat("Last Move X", lastMove.x);
        playerAnimator.SetFloat("Last Move Y", lastMove.y);
    }
}