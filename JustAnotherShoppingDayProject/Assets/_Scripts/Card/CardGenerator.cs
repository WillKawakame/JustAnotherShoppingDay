using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public Items items;
    
    private void Start() {
        //Set Random Skins
        for(int i = 0; i < Card.Skins.Length; i++){
            Card.Skins[i] = Random.Range(1, items.itemTypes[i].items.Length);
        }

        //Set the total value
        Card.TotalValue += items.itemTypes[1].items[Card.Skins[1]].Price;
        Card.TotalValue += items.itemTypes[2].items[Card.Skins[2]].Price;

        //You start with 45% of the TotalValue 
        Card.YourMoney = Card.TotalValue * 0.45f;
    }
}
