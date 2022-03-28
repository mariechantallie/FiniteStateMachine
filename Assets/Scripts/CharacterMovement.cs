using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMovement : MonoBehaviour {
    [SerializeField] PlayerCharacter character;
    [SerializeField] KeyCode jumpKey = KeyCode.Space;
    [SerializeField] float jumpForce = 500f;
    Rigidbody rb;
    StateMachine playerState;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        playerState = character.CharacterState;
    }

    private void Update() {
        if(Input.GetKey(jumpKey)) {
            Jump();
        }
    }

    private void Jump() {
        if(character.IsGrounded) {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
