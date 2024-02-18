using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericScript : MonoBehaviour
{

    private int money;
    private int items;



    private int collectableValue = 5;
    private int itemCost = 10;
    private int ballCost = 10;

    public UserInterface userInterface;

    private void Awake()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindGameObjectWithTag("GameController").GetComponent<UserInterface>();
        
        
        
       
    }

    public void Collect()
    {
        Neuro.AddCoins (5);
        Neuro.AddExp (5);
        money += collectableValue;
        
    }

    public void CollectExtra()
    {
        Neuro.AddCoins (250);
        money += collectableValue;
        Neuro.AddExp (400);
        
    }

    public void NivelJugadoA111()
    {
        Neuro.A111Jugado (1);

    }

    public void NivelSuperadoA111()
    {
        Neuro.A111Superado (1);
        
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

    public void BuyBall()
    {
        if (money >= ballCost)
        {
            Debug.Log("Bola Comprada");
            money -= itemCost;
        }
        else
        {
            Debug.Log("Can't Buy!!");
        }
        
    }

    public void Mantenervalor()
    {
        money += 0;
    }

    

    private void OnDestroy()
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
        
        

        //PlayerPrefs.SetInt(moneyPrefsName,money);
        //PlayerPrefs.SetInt(itemsPrefsName,items);
        
    }
}
