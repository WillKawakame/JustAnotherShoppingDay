using UnityEngine;

public class BodyPartSelector : MonoBehaviour{
    public Items Items;
    public CharacterBody characterBody;
    public CharacterBody currentCharacterBody;

    public void NextItem(int partIndex, int index){
        currentCharacterBody.BodyParts[partIndex].BodyPartItem = Items.itemTypes[partIndex].items[index];
    }
}
  