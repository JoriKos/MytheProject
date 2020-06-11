using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayItemAmounts : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mat1;
    [SerializeField] TextMeshProUGUI mat2;
    [SerializeField] TextMeshProUGUI mat3;
    [SerializeField] TextMeshProUGUI mat4;
    [SerializeField] TextMeshProUGUI pot1;
    [SerializeField] TextMeshProUGUI pot2;
    [SerializeField] TextMeshProUGUI pot3;
    [SerializeField] TextMeshProUGUI pot4;
    [SerializeField] TextMeshProUGUI money;

    OpenCloseInventory InventoryCheck;
    PlayerInventory playerInv;
    PlayerMoney playerMoney;
    private bool itemAmountsAreSet = false;

    void Start()
    {
        InventoryCheck = gameObject.GetComponent<OpenCloseInventory>();
        playerInv = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        playerMoney = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoney>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InventoryCheck.inventoryOpen == false && itemAmountsAreSet == true)
            itemAmountsAreSet = false;
        else if (InventoryCheck.inventoryOpen == true && itemAmountsAreSet == false && playerInv.isInitialized ==true)
        {
			mat1.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.GatheringItem));
			mat2.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.FoodItem));
			mat3.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.MaterialItem));
			mat4.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.KeyItem));
            pot1.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.PotionOne));
            pot2.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.PotionTwo));
            pot3.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.PotionThree));
            pot4.SetText(playerInv.GetItemAmountFromInventory(ItemTypes.PotionFour));

            itemAmountsAreSet = true;
        }
        money.SetText( "Money: "+playerMoney.money.ToString());
    }
}
