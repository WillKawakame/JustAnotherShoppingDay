using UnityEngine;
using UnityEngine.UI;

public class RenderCard : MonoBehaviour{

    public GameObject Main;
    public Items items_;
    public GameObject Window_1;
    public GameObject Window_2;
    private int windowNow = 1;

    public Text Name;
    public Text Price;
    public Image Icon;
    
    private void Start() {
        UpdateText();
        Time.timeScale = 0;
    }

    private void Update() {
        UpdateText();
    }

    private void UpdateText() {
        var item = items_.itemTypes[windowNow].items[Card.Skins[windowNow]];
        Name.text = item.ItemName;
        Price.text = item.Price.ToString() + "$";
        Icon.sprite = item.Icon;
    }

    public void Close(){
        Destroy(Main);
        Time.timeScale = 1;
    }

    public void ChangeWindow(int i){
        windowNow += i;
        if(windowNow == 1){
            Window_1.SetActive(true);
            Window_2.SetActive(false);
        }
        if(windowNow == 2){
            Window_1.SetActive(false);
            Window_2.SetActive(true);
        }
    }
}
