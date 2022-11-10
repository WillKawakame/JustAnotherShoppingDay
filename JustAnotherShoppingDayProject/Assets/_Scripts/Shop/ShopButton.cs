using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public Items items;
    public BodyPartsManager bodyPartsManager;
    public Shop shop;
    public GameObject BuyButton;
    public Sprite buy;
    public Sprite equip;

    private void Update() {
        var item = items.itemTypes[shop.BodyPart].items[shop.itemSelect];
        if(item.isAvaliable){
            //Equip Button
            BuyButton.GetComponent<Image>().sprite = equip;
            BuyButton.GetComponentInChildren<Text>().text = "Equip"; 
        }else{
            //Buy Button
            BuyButton.GetComponent<Image>().sprite = buy;
            BuyButton.GetComponentInChildren<Text>().text = "Buy: " + item.Price; 
        }
    }

    public void Button(){
        var item = items.itemTypes[shop.BodyPart].items[shop.itemSelect];
        if(item.isAvaliable){
            Equip();
        }else{
            Buy();
        }
    }

    public void Buy(){
        var item = items.itemTypes[shop.BodyPart].items[shop.itemSelect];
        if(Card.YourMoney >= item.Price){
            item.isAvaliable = true;
        }else{
            //Can't buy
        }
    }

    public void Equip(){
        var item = items.itemTypes[shop.BodyPart].items[shop.itemSelect];
        bodyPartsManager.currentCharacterBody.BodyParts[shop.BodyPart].BodyPartItem = item;
        bodyPartsManager.OverrideAnimations();
    }
}
