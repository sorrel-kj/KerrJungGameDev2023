// Sorrel Kerr-Jung 2023.09.12
// Script for first person character controls


// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : MonoBehaviour
{

    // Player Variables
    public float speed = 2.0f;
    public float gravity = -10.0f;
    public float jumpForce = 2.0f;

    // Move/Look Variables
    private CharacterController characterController;
    private Vector2 moveInput;
    private Vector3 playerVelocity;
    private bool onGround;
    private Vector2 mouseMovement;

    //Camera Variables
    public Camera cameraLive;
    public float sensitivity = 25.0f;
    private float camXRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context) 
    {
        
    }

    public void OnLook(InputAction.CallbackContext context) 
    {
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
