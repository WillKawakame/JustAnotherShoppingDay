using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour{
    //
    //PlayerInputs
    //

    private PlayerInput PlayerInput => GetComponent<PlayerInput>();
    private InputActionAsset CharacterInputActions;
    
    [HideInInspector]public Vector2 MoveDirection;

    public void OnMovement(InputAction.CallbackContext action){
        Vector2 value = action.ReadValue<Vector2>();
        MoveDirection = (Vector2.up * value.y) + (Vector2.right * value.x);
    }
}
