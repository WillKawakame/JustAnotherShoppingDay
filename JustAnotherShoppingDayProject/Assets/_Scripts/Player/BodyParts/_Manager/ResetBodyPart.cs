using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBodyPart : MonoBehaviour
{
    public CharacterBody characterBody;
    public CharacterBody currentCharacterBody;
    public CharacterBody defaultCharacterBody;

    private void Awake() {
        for(int i = 0; i < characterBody.BodyParts.Length; i++){
            currentCharacterBody.BodyParts[i].BodyPartItem = defaultCharacterBody.BodyParts[i].BodyPartItem;
            characterBody.BodyParts[i].BodyPartItem = defaultCharacterBody.BodyParts[i].BodyPartItem;
        }
    }
}
