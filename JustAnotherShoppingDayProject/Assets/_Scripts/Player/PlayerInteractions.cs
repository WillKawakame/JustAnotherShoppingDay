using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour{
    public LayerMask Prop;
    public LayerMask Npc;
    public LayerMask FittingRoom;

    public void Interaction(){
        //Interact With Prop
        
        RaycastHit2D circleCast = Physics2D.CircleCast(transform.position, 1.2f, Vector2.up, 1.2f, Prop);
        if(circleCast){
             circleCast.collider.GetComponent<Actions>().Action();
        }

    }
}
