
using UnityEngine;

public class Player : MonoBehaviour{
    //
    //Store basic components from player
    //

    
    public PlayerInputManager PlayerInput => GetComponent<PlayerInputManager>(); 
    public Rigidbody2D Rb => GetComponent<Rigidbody2D>(); 
    public Animator Animator_ => GetComponent<Animator>();
}
