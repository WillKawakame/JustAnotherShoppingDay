using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public ActionsList actionsList;
    public void Action(){
        switch(actionsList){
            case ActionsList.None:
                Debug.Log("Nothing here");
                break;
            case ActionsList.GiveDiscount:
                Debug.Log("You have found a random discount value");
                break;
            case ActionsList.GiveMoney:
                Card.YourMoney += 15;
                Debug.Log("You have found a random amount of money");
                break;
            case ActionsList.GiveLollipop:
                Debug.Log("You have found a lollipop");
                break;
        }
    }

    public enum ActionsList{
        GiveDiscount,
        GiveMoney,
        GiveLollipop,
        None
    }
}