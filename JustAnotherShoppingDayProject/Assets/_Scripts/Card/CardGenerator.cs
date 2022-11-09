using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public Items items;
    
    private void Awake() {
        //Set Random Skins
        for(int i = 0; i < Card.Skins.Length; i++){
            Card.Skins[i] = Random.Range(0, items.itemTypes[i].items.Length);
        }

        //Set the total value
        for(int i = 0; i < Card.Skins.Length; i++){
            //Debug.Log(items.itemTypes[i].items[Card.Skins[i]].Price);
            Card.TotalValue += items.itemTypes[i].items[Card.Skins[i]].Price;
        }

        //You start with 45% of the TotalValue 
        Card.YourMoney = Card.TotalValue * 0.45f;
    }

    void Start(){
        
    }

}
