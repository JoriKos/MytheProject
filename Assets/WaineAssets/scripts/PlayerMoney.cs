using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int money { get; private set; }
    int maxMoney = 9999999;

    // Start is called before the first frame update
    void Start()
    {
        money = 0;
    }

	 void Update()
	{
		if(money > maxMoney)
		{
			money = maxMoney;
			Debug.Log("money capacity reached");
		}
	}

	public void AddMoney(int amount)
	{
        money += amount;
	}
    public void RemoveMoney(int amount)
	{
        money -= amount;
	}
}
