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
        inventoryMenu.SetActive(true);
        inventoryIsOpen = true;
    }

    private void CloseInventoryMenu()
    {
        inventoryMenu.SetActive(false);
        inventoryIsOpen = false;
    }
}
