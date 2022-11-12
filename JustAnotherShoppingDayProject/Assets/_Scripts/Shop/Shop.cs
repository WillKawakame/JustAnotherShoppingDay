using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Items items;
    public Image Icon;
    public Text Name;
    public GameObject NextButton;
    public GameObject PreviousButton;
    [HideInInspector]
    public int BodyPart = 1;
    [HideInInspector]
    public int itemSelect = 1;
    private void Awake() {
         //Reset Shop
        for(int i = 0; i < items.itemTypes.Length; i++){
            for(int j = 0; j < items.itemTypes[i].items.Length; j++){
                items.itemTypes[i].items[j].isAvaliable = false;
            }
        }
    }
    private void Start() {
        //Set Name and Icon from item to UI
        var item = items.itemTypes[BodyPart].items[itemSelect];
        Icon.sprite = item.Icon;
        Name.text = item.ItemName;
    }

    private void Update() {
        //Set Name and Icon from item to UI
        var item = items.itemTypes[BodyPart].items[itemSelect];
        Icon.sprite = item.Icon;
        Name.text = item.name;


        //Disable next or previous button
        if(itemSelect == 1){
            PreviousButton.SetActive(false);
        }else{
            PreviousButton.SetActive(true);
        }
        if(itemSelect == items.itemTypes[BodyPart].items.Length - 1){
            NextButton.SetActive(false);
        }else{
            NextButton.SetActive(true);
        }
    }


    public void nextItem(int i){
        itemSelect += i;
    }

}
