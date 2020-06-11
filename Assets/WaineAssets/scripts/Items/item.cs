using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public abstract class Item : MonoBehaviour
{
	abstract public void AddItemToPlayerInventory();
	abstract public void InitializePlayerInventory();

}
