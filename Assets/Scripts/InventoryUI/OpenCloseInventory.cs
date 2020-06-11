using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpenCloseInventory : MonoBehaviour
{
    private bool inventoryIsOpen = false;
    public bool inventoryOpen
    {
        get { return inventoryIsOpen;}
        set { inventoryIsOpen = value;}
    }

    [SerializeField] private GameObject inventoryMenu;

    PlayerInventory playerInv;

	private void Start()
	{
       playerInv = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
	}
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(inventoryIsOpen){
                CloseInventoryMenu();
            }
            else
            {
                OpenInventoryMenu();
            }
        }
    }

    private void OpenInventoryMenu()
    {
            if (playerInv.GetInitialization() == true)
		{
        inventoryMenu.SetActive(true);
        inventoryIsOpen = true;
		}
            else if (playerInv.GetInitialization() == false)
            playerInv.InitializeInventory();
    }

    private void CloseInventoryMenu()
    {
        inventoryMenu.SetActive(false);
        inventoryIsOpen = false;
    }
}
