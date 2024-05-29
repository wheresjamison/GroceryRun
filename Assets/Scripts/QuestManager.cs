using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;


public class QuestManager : MonoBehaviour
{

    public int numApplesNeeded;
    public int numBananasNeeded;
    public int numWatermelonsNeeded;
    public int numOnionsNeeded;
    public int numPotatosNeeded;
    public int numCornNeeded;
    public int numCheeseNeeded;
    public int numEggsNeeded;
    public int numMilkNeeded;

    public bool orderAssigned;

    public int assigned;
    private string[] addresses;
    public int assignedAddressIndex;
    public string address;

    public string apples;
    public string bananas;
    public string watermelons;
    public string onions;
    public string potatos;
    public string corn;
    public string eggs;
    public string milk;
    public string cheese;


    // Start is called before the first frame update
    void Start()
    {
        address = "filler";
        apples = "0";
        bananas = "0";
        watermelons = "0";
        onions = "0";
        potatos = "0";
        corn = "0";
        eggs = "0";
        milk = "0";
        cheese = "0";

        ResetItemsNeededToZero();
        orderAssigned = false;
        //65 different addresses
        //First 33 are located in the West side of town  - WestField
        //next part is the north side of town, skyscrapers. 9 buildings
        //center part of town, 3 medium buildings
        //3 buildings under WestField
        //complexes located in the southern part of town. 5 buildings. 3 sides - 15 doors total
        //from left to right, top to bottom
        addresses = new string[] { "1001 WestField", "1002 WestField", "1003 WestField", "1004 WestField", "1005 WestField", "1006 WestField", "1007 WestField", "1008 WestField", "1009 WestField", "1010 WestField", "1011 WestField", "1012 WestField", "1013 WestField", "1014 WestField", "1015 WestField", "1016 WestField", "1017 WestField", "1018 WestField", "1019 WestField", "1020 WestField", "1021 WestField", "1022 WestField", "1023 WestField", "1024 WestField", "1025 WestField", "1026 WestField", "1027 WestField", "1028 WestField", "1029 WestField", "1030 WestField", "1031 WestField", "1032 WestField", "1033 WestField", "1111 NorthPark", "1112 NorthPark", "1113 NorthPark", "1114 NorthPark", "1115 NorthPark", "1116 NorthPark", "1117 NorthPark", "1118 NorthPark", "1119 NorthPark", "1201 CenterPlace", "1202 CenterPlace", "1203 CenterPlace", "2101 SouthWestern", "2102 SouthWestern", "2103 SouthWestern", "1001 MustardComplex #1 ", "1001 MustardComplex #2 ", "1001 MustardComplex #3", "1002 MayoManor #1", "1002 MayoManor #2", "1002 MayoManor #3", "4000 KetchupCanyon #1", "4000 KetchupCanyon #2", "4000 KetchupCanyon #3", "4001 SaltStreet #1", "4001 SaltStreet #2", "4001 SaltStreet #3", "5000 PepperPalace #1", "5000 PepperPalace #3", "5000 PepperPalace #3" };
        assignedAddressIndex = addresses.Length; //65

    }

    public void GenerateHouse()
    {
        assignedAddressIndex = Random.Range(1, assignedAddressIndex); //between 1-65 
        address = addresses[assignedAddressIndex];
        Debug.Log("Address assigned : " + address);
    }

    public void GenerateOrder()
    {
        numApplesNeeded = Random.Range(0, 5);
        numBananasNeeded = Random.Range(0, 5);
        numWatermelonsNeeded = Random.Range(0, 5);
        numOnionsNeeded = Random.Range(0, 5);
        numPotatosNeeded = Random.Range(0, 5);
        numCornNeeded = Random.Range(0, 5);
        numCheeseNeeded = Random.Range(0, 5);
        numEggsNeeded = Random.Range(0, 5);
        numMilkNeeded = Random.Range(0, 5);
        convertToString();

        orderAssigned = true;

        Debug.Log("Order: Apple = " + numApplesNeeded + ".");
        Debug.Log("Order: Banana = " + numBananasNeeded + ".");
        Debug.Log("Order: Watermelon = " + numWatermelonsNeeded + ".");
        Debug.Log("Order: Onion = " + numOnionsNeeded + ".");
        Debug.Log("Order: Potato = " + numPotatosNeeded + ".");
        Debug.Log("Order: Corn = " + numCornNeeded + ".");
        Debug.Log("Order: Cheese = " + numCheeseNeeded + ".");
        Debug.Log("Order: Egg = " + numEggsNeeded + ".");
        Debug.Log("Order: Milk = " + numMilkNeeded + ".");
    }

    public void ResetItemsNeededToZero()
    {
        numApplesNeeded = 0;
        numBananasNeeded = 0;
        numWatermelonsNeeded = 0;
        numOnionsNeeded = 0;
        numPotatosNeeded = 0;
        numCornNeeded = 0;
        numCheeseNeeded = 0;
        numEggsNeeded = 0;
        numMilkNeeded = 0;
        convertToString();
    }

    public void convertToString()
    {
        apples = numApplesNeeded.ToString();
        bananas = numBananasNeeded.ToString();
        watermelons = numWatermelonsNeeded.ToString();
        onions = numOnionsNeeded.ToString();
        potatos = numPotatosNeeded.ToString();
        corn = numCornNeeded.ToString();
        eggs = numEggsNeeded.ToString();
        milk = numMilkNeeded.ToString();
        cheese = numCheeseNeeded.ToString();
    }
}
