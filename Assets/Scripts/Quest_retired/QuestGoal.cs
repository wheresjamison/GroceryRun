using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal : MonoBehaviour
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool isReached()
    {
        return (currentAmount >= requiredAmount);
    }
        
    public void ItemOfOrderRetrieved()
    {
        if (goalType == GoalType.Small)
        {
            currentAmount++;
        }
    }
}

public enum GoalType
{
    Small, //1 bag delivery
    Medium, //2 bag deliver
    Heavy //3 bag deliver
}
