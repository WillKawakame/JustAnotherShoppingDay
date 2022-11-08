using UnityEngine;

[CreateAssetMenu(fileName = "New CharacterBody", menuName = "CharacterBody")]
public class CharacterBody : ScriptableObject{
    public BodyPart[] BodyParts;
}

[System.Serializable]
public class BodyPart{
    public string BodyPartName;
    public Item BodyPartItem;
}