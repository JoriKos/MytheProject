using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CraftItems : MonoBehaviour
{
	PlayerInventory playerInv;
	// Start is called before the first frame update
	private void Start()
	{
		playerInv = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
	}
	public void CraftPotionOne()
	{
		int c = 0;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.GatheringItem) >= 5)
			c += 1;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.MaterialItem) >= 4)
			c += 1;
		if (c == 2)
		{
			playerInv.RemoveItem(ItemTypes.GatheringItem, 2);
			playerInv.RemoveItem(ItemTypes.MaterialItem, 4);
			playerInv.AddItem(ItemTypes.PotionOne);
		}
	}
	public void CraftPotionTwo()
	{
		int c = 0;

		if (playerInv.GetIntAmountFromInventory(ItemTypes.FoodItem) >= 2)
			c += 1;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.KeyItem) >= 4)
			c += 1;
		if(c == 2)
		{
		playerInv.RemoveItem(ItemTypes.FoodItem, 2);
		playerInv.RemoveItem(ItemTypes.KeyItem, 4);
		playerInv.AddItem(ItemTypes.PotionTwo);
		}
	}
	public void CraftPotionThree()
	{
		int c = 0;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.GatheringItem) >= 4)
			c += 1;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.FoodItem) >= 6)
			c += 1;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.KeyItem) >= 3)
			c += 1;
		if( c == 3)
		{
			playerInv.RemoveItem(ItemTypes.GatheringItem, 4);
			playerInv.RemoveItem(ItemTypes.FoodItem, 6);
			playerInv.RemoveItem(ItemTypes.KeyItem, 3);
			playerInv.AddItem(ItemTypes.PotionThree);
		}
	}
	public void CraftPotionFour()
	{
		int c = 0;
		if(playerInv.GetIntAmountFromInventory(ItemTypes.GatheringItem) >= 2)
			c += 1;
		if(playerInv.GetIntAmountFromInventory(ItemTypes.FoodItem) >= 8)
			c  += 1;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.MaterialItem) >= 5)
			c += 1;
		if (playerInv.GetIntAmountFromInventory(ItemTypes.KeyItem) >= 7)
			c += 1;
		if(c == 4)
		{
			playerInv.RemoveItem(ItemTypes.GatheringItem, 2);
			playerInv.RemoveItem(ItemTypes.FoodItem, 8);
			playerInv.RemoveItem(ItemTypes.MaterialItem, 5);
			playerInv.RemoveItem(ItemTypes.KeyItem, 7);
			playerInv.AddItem(ItemTypes.PotionFour);
		}
	}
}
