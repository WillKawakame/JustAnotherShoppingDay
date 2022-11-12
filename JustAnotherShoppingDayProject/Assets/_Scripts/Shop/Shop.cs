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
    private void Start() {
        var item = items.itemTypes[BodyPart].items[itemSelect];
        Icon.sprite = item.Icon;
        Name.text = item.ItemName;
    }

    private void Update() {
        var item = items.itemTypes[BodyPart].items[itemSelect];
        Icon.sprite = item.Icon;
        Name.text = item.name;

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
