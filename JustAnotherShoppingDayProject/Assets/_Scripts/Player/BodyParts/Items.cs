using UnityEngine;

[CreateAssetMenu(fileName = "New ItemsList", menuName = "ItemsList")]
public class Items : ScriptableObject{
    public ItemType[] itemTypes;
}

[System.Serializable]
public class ItemType{
    public Item[] items;
}
