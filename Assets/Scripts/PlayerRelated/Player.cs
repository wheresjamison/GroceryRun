using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float CashBalance;
    public float time = 2;

    public int bagsCarrying = 0;

    public Quest quest;

    public void ShopAndDeliver()
    {
        if (quest.isActive)
        {
            //create an action that starts the timer.
            quest.goal.ItemOfOrderRetrieved();
            if (quest.goal.isReached())
            {
                quest.StopClock();
                if (time >= quest.timeGoal)
                {
                    CashBalance += quest.cashReward * 2;
                }
                else
                {
                    CashBalance += quest.cashReward;

                }
                quest.Complete();
            }
        }
    }
}
