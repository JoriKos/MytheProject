
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool isInitialized { get; private set; }

    Dictionary<ItemTypes, int> playerInventory = new Dictionary<ItemTypes, int>();

    public void InitializeInventory()
    {
        if (isInitialized)
            return;
        else if (!isInitialized)
        {
            playerInventory.Clear();
            foreach (ItemTypes item in Enum.GetValues(typeof(ItemTypes)))
            {
                playerInventory.Add(item, 0);
            }
            isInitialized = true;
        }
    }
    public bool GetInitialization()
    {
        return isInitialized;
    }
    public void AddItem(ItemTypes item)
    {
        playerInventory[item] += 1;
    }
    public void RemoveItem(ItemTypes item, int amount)
    {
        playerInventory[item] -= amount;
        if (playerInventory[item] < 0)
            playerInventory[item] = 0;
    }
    public void TestFunc()
    {
        foreach (KeyValuePair<ItemTypes, int> items in playerInventory)
        {
            Debug.Log("Key: " + items.Key + " Value:"+ items.Value + "\n");
        }
    }
    public string GetItemAmountFromInventory(ItemTypes item)
    {
       string amount = playerInventory[item].ToString();
        return amount;
    }
    public int GetIntAmountFromInventory(ItemTypes item)
	{
        int amount = playerInventory[item];
        return amount;
	}
	private void Awake()
	{
        InitializeInventory();
	}
}

