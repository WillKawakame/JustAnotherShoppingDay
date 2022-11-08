using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    //
    //Player Movement
    //No state machine needed for this one
    //


    private Player player => GetComponent<Player>();
    
    [SerializeField] private float moveSpeed = 3;

    void Start(){   
    }

    void Update(){
    }

    void FixedUpdate() {
        Move();
    }

    private void Move(){
        player.Rb.velocity = new Vector2(player.PlayerInput.MoveDirection.x * moveSpeed, player.PlayerInput.MoveDirection.y * moveSpeed);

        //Set Walking Animation
        player.Animator_.SetFloat("Horizontal", player.Rb.velocity.x);
        player.Animator_.SetFloat("Vertical", player.Rb.velocity.y);
        player.Animator_.SetFloat("Speed", player.Rb.velocity.sqrMagnitude);
    }
}
