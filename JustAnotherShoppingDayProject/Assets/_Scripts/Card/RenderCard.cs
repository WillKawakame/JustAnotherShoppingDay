using UnityEngine;
using UnityEngine.UI;

public class RenderCard : MonoBehaviour{
    public Text YourMoney;
    public Text TotalValue;
    
    private void Start() {
        YourMoney.text = "YourMoney:" + Card.YourMoney.ToString();
        TotalValue.text = "TotalValue:" + Card.TotalValue.ToString();
    }
}
