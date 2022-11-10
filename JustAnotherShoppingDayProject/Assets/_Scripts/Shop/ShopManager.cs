using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject Store;
    public Shop shop;
    public int BodyPart;
    public void OpenStore(){
        Store.SetActive(true);
        Time.timeScale = 0;
        shop.BodyPart = BodyPart;
        shop.itemSelect = 1;
    }
    public void CloseStore(){
        Store.SetActive(false);
        Time.timeScale = 1;
    }
}
