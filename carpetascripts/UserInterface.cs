using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UserInterface : MonoBehaviour
{

    [SerializeField]
    private Text moneyIndicator;
    [SerializeField]
    private Text itemIndicator;

    private GenericScript genericScript;

    void Start()
    {
        genericScript = FindObjectOfType<GenericScript>();
    }


    public void BuyButton()
    {
        genericScript.BuyItem();
    }

    public void BuyButtonBall()
    {
        genericScript.BuyBall();
    }

    public void CollectButton()
    {
        genericScript.Collect();
    }

    public void CollectPlus()
    {
        genericScript.CollectExtra();
    }


}
