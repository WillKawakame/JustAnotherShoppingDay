using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Items items;
    public Sprite Icon;
    public Text Name;
    public GameObject NextButton;
    public GameObject PreviousButton;
    [HideInInspector]
    public int BodyPart = 1;
    [HideInInspector]
    public int itemSelect = 1;

    private void Update() {
        if(itemSelect == 1){
            PreviousButton.SetActive(false);
        }else{
            PreviousButton.SetActive(true);
        }
        if(itemSelect == items.itemTypes[BodyPart].items.Length){
            NextButton.SetActive(false);
        }else{
            NextButton.SetActive(true);
        }
    }

    public void GetItem(){
        var item = items.itemTypes[BodyPart].items[itemSelect];
        Icon = item.Icon;
        Name.text = item.name;
    }

    public void nextItem(int i){
        itemSelect += i;
        GetItem();
    }

}
