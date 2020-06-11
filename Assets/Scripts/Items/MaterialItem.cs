using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialItem : Item
{
    PlayerInventory playerInv;
    private void Awake()
    {
        playerInv = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
    }
    public override void AddItemToPlayerInventory()
    {
        ItemTypes myItem = ItemTypes.MaterialItem;
        playerInv.AddItem(myItem);
        playerInv.TestFunc();
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            InitializePlayerInventory();
        AddItemToPlayerInventory();
    }
    public override void InitializePlayerInventory()
    {
        if (playerInv.GetInitialization() == true)
            return;
        else if (playerInv.GetInitialization() == false)
            playerInv.InitializeInventory();
    }
}
