using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour{
    //
    //PlayerInputs
    //

    private PlayerInput PlayerInput => GetComponent<PlayerInput>();
    private PlayerInteractions playerInteractions => GetComponent<PlayerInteractions>();
    private InputActionAsset CharacterInputActions;
    
    [HideInInspector]public Vector2 MoveDirection;

    public void OnMovement(InputAction.CallbackContext action){
        Vector2 value = action.ReadValue<Vector2>();
        MoveDirection = (Vector2.up * value.y) + (Vector2.right * value.x);
    }

    public void OnInterectAction(InputAction.CallbackContext action){
        if(action.performed){
            playerInteractions.Interaction();
        }
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 1.2f);
    }
}
