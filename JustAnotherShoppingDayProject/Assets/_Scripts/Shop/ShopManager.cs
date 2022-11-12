using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject Store;
    public Shop shop;
    public int BodyPart;
    public void OpenStore(){
        Store.SetActive(true);
        shop.BodyPart = BodyPart;
        Debug.Log(shop.BodyPart);
        shop.itemSelect = 1;
    }
    public void CloseStore(){
        Store.SetActive(false);
    }
}
