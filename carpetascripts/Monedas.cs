using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public static Monedas monedas;

    public int money;
    private int items;
    private string moneyPrefsName="Money";
    private string itemsPrefsName="Items";

    private void Awake()
    {
        if (monedas == null)
        {
            monedas = this;
            DontDestroyOnLoad(gameObject);
            LoadData();
        }

        else {
        
        if(monedas != this)
        {
            Destroy(gameObject);
        }
    }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetItems(int i)
    {
        items = i;

    }

    public int GetItems()
    {
        return items;
    }

    private void OnDestroy()
    {
        SaveData();
    }

    private void LoadData()
    {
        money = PlayerPrefs.GetInt(moneyPrefsName,0);
        items = PlayerPrefs.GetInt(itemsPrefsName,0);



    }

    private void SaveData()
    {


        PlayerPrefs.SetInt(moneyPrefsName,money);
        PlayerPrefs.SetInt(itemsPrefsName,items);
        
    }
}
