using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Items items_;

    public Text YourMoney;
    public Text TotalPrice;

    public Image Hat;
    public Image Outfit;
    private void Update() {
        Hat.sprite = items_.itemTypes[1].items[Card.Skins[1]].Icon;
        Outfit.sprite = items_.itemTypes[2].items[Card.Skins[2]].Icon;
        YourMoney.text = "Your Money: " + Card.YourMoney;
        TotalPrice.text = "Total Value: " + Card.TotalValue;


    }
}
