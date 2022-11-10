using UnityEngine;
using UnityEngine.UI;

public class RenderCard : MonoBehaviour{

    public GameObject Main;
    public Items items_;
    public GameObject Window_1;
    public GameObject Window_2;
    public GameObject Window_3;
    private int windowNow = 0;

    public Text Name;
    public Text Price;
    public Sprite Icon;
    
    private void Start() {
        UpdateText();
        Time.timeScale = 0;
    }

    private void Update() {
        UpdateText();
    }

    private void UpdateText() {
        var item = items_.itemTypes[windowNow].items[Card.Skins[windowNow]];
        Name.text = item.name;
        Price.text = item.Price.ToString() + "$";
        Icon = item.Icon;
    }

    public void Close(){
        Destroy(Main);
        Time.timeScale = 1;
    }

    public void ChangeWindow(int i){
        windowNow += i;
        if(windowNow == 0){
            Window_1.SetActive(true);
            Window_2.SetActive(false);
            Window_3.SetActive(false);
        }
        if(windowNow == 1){
            Window_1.SetActive(false);
            Window_2.SetActive(true);
            Window_3.SetActive(false);
        }
        if (windowNow == 2){
            Window_1.SetActive(false);
            Window_2.SetActive(false);
            Window_3.SetActive(true);
        }
    }
}
