using UnityEngine;

public class Actions : MonoBehaviour
{
    public ActionsList actionsList;
    public DialogueTrigger dialogueTrigger;
    public void Action(){
        switch(actionsList){
            case ActionsList.None:
                Debug.Log("Nothing here");
                break;
            case ActionsList.GiveDiscount:
                Card.Discounts += 1;
                actionsList = ActionsList.None;
                Debug.Log("You have found a random discount value");
                break;
            case ActionsList.GiveMoney:
                Card.YourMoney += 15;
                actionsList = ActionsList.None;
                dialogueTrigger.TriggerDialogue();
                Debug.Log("You have found a random amount of money");
                break;
            case ActionsList.GiveLollipop:
                actionsList = ActionsList.None;
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