using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour{
    public LayerMask Interactable;

    public void Interaction(){
        //Interact With Prop
        
        RaycastHit2D circleCast = Physics2D.CircleCast(transform.position, 1.2f, Vector2.up, 1.2f, Interactable);
        if(circleCast){
            if(circleCast.collider.CompareTag("Prop")){
                circleCast.collider.GetComponent<Actions>().Action();
            }
            if(circleCast.collider.CompareTag("Shop")){
                circleCast.collider.GetComponent<ShopManager>().OpenStore();
            }
        }

    }
}
