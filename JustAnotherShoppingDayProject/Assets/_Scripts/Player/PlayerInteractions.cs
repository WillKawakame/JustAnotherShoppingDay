using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour{
    public LayerMask Interactable;
    public Animator animator;

    private void Update() {
        
        RaycastHit2D circleCast = Physics2D.CircleCast(transform.position, 1f, Vector2.up, 1f, Interactable);
        if(circleCast){
            animator.SetBool("Enable", true);
        }else{
            animator.SetBool("Enable", false);
        }
    }

    public void Interaction(){
        //Interact With Prop
        RaycastHit2D circleCast = Physics2D.CircleCast(transform.position, 1f, Vector2.up, 1f, Interactable);
        if(circleCast){
            if(circleCast.collider.CompareTag("Prop")){
                circleCast.collider.GetComponent<Actions>().Action();
            }
            if(circleCast.collider.CompareTag("Shop")){
                circleCast.collider.GetComponent<ShopManager>().OpenStore();
            }
            if(circleCast.collider.CompareTag("Npc")){
                circleCast.collider.GetComponent<DialogueTrigger>().TriggerDialogue();
            }
        }

    }
}
