using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas2 : MonoBehaviour
{
    private int money;
    private int items;



    private int collectableValue = 5;
    private int itemCost = 10;

    public UserInterface userInterface;

    private void Awake()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindGameObjectWithTag("GameController").GetComponent<UserInterface>();
        
        LoadData();
    }

    public void Collect()
    {
        money += collectableValue;
        
    }

    public void BuyItem()
    {
        if (money >= itemCost)
        {
            items++;
            money -= itemCost;
        }
        else
        {
            Debug.Log("Can't Buy!!");
        }
        
    }

    

    private void Ondestroy()
    {
        SaveData();
    }

    private void LoadData()
    {
        //money = PlayerPrefs.GetInt(moneyPrefsName,0);
        //items = PlayerPrefs.GetInt(itemsPrefsName,0);

        money = Monedas.monedas.money;
        items = Monedas.monedas.GetItems();

    }

    private void SaveData()
    {
        Monedas.monedas.money = money;
        Monedas.monedas.SetItems(items);

        //PlayerPrefs.SetInt(moneyPrefsName,money);
        //PlayerPrefs.SetInt(itemsPrefsName,items);
        
    }
}
