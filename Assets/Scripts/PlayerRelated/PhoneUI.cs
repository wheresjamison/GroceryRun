using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhoneUI : MonoBehaviour
{
    public TextMeshProUGUI questAddress;
    public TextMeshProUGUI questNumApples;
    public TextMeshProUGUI questNumBananas;
    public TextMeshProUGUI questNumWatermelons;
    public TextMeshProUGUI questNumOnions;
    public TextMeshProUGUI questNumPotatos;
    public TextMeshProUGUI questNumCorns;
    public TextMeshProUGUI questNumEggs;
    public TextMeshProUGUI questNumMilks;
    public TextMeshProUGUI questNumCheeses;
    private QuestManager quest;
    public TextMeshProUGUI invAddress;
    public TextMeshProUGUI invNumApples;
    public TextMeshProUGUI invNumBananas;
    public TextMeshProUGUI invNumWatermelons;
    public TextMeshProUGUI invNumOnions;
    public TextMeshProUGUI invNumPotatos;
    public TextMeshProUGUI invNumCorns;
    public TextMeshProUGUI invNumEggs;
    public TextMeshProUGUI invNumMilks;
    public TextMeshProUGUI invNumCheeses;
    private ObjectiveManager objective;

    void Start()
    {
        quest = FindAnyObjectByType<QuestManager>();
        objective = FindAnyObjectByType<ObjectiveManager>();
    }

    void Update()
    {
        questNumApples.text = quest.apples;
        questNumBananas.text = quest.bananas;
        questNumWatermelons.text = quest.watermelons;
        questNumOnions.text = quest.onions;
        questNumPotatos.text = quest.potatos;
        questNumCorns.text = quest.corn;
        questNumEggs.text = quest.eggs;
        questNumMilks.text = quest.milk;
        questNumCheeses.text = quest.cheese;

        questAddress.text = quest.address;

        invNumApples.text = objective.apples;
        invNumBananas.text = objective.bananas;
        invNumWatermelons.text = objective.watermelons;
        invNumOnions.text = objective.onions;
        invNumPotatos.text = objective.potatos;
        invNumCorns.text = objective.corns;
        invNumEggs.text = objective.eggs;
        invNumMilks.text = objective.milks;
        invNumCheeses.text = objective.cheeses;

        invAddress.text = quest.address;

    }
}
