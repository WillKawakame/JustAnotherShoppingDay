using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Item : ScriptableObject {
    public string ItemName;
    public int ItemID;
    public Sprite Icon;
    public AnimationClip[] Animations;
}

