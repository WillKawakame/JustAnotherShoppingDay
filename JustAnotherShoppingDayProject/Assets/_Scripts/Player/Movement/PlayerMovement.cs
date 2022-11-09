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

        if(player.Rb.velocity.x <= 0f){
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }else{
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        //Set Walking Animation
        if(player.PlayerInput.MoveDirection.x != 0){
            player.Animator_.SetFloat("Horizontal", 1);
        }else{
            player.Animator_.SetFloat("Horizontal", 0);
        }
        player.Animator_.SetFloat("Vertical", player.Rb.velocity.y);
        player.Animator_.SetFloat("Speed", player.Rb.velocity.sqrMagnitude);
    }
}
