using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;


public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public float coins;
    // public Text CoinsTXT;
    public float addCoins;
    public GameManager gameManager;
    public UpdateText updateText;


    void Start()
    {

        // CoinsTXT.text = "Baacks:" + coins.ToString();
        //ID's
        shopItems[1,1] = 1;
        shopItems[1,2] = 2;
        shopItems[1,3] = 3;
        shopItems[1,4] = 4;


        //Price
        shopItems[2,1] = 10;
        shopItems[2,2] = 40;
        shopItems[2,3] = 100;
        shopItems[2,4] = 1000;

        
        //Quantity
        shopItems[3,1] = 0;
        shopItems[3,2] = 0;
        shopItems[3,3] = 0;
        shopItems[3,4] = 0;

    }

    public void CoinClick()
    {

        coins+=addCoins;
        // coins+=gameManager.finalCoins;
        coins++;
        int rounded = (int)coins;
        coins = (float)rounded;
        // updateText.Text();



    }
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        Console.WriteLine(updateText.totalCoins);
        updateText.totalCoins = check;
        if (((check)>= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID]))
        {
            coins -= shopItems[2,ButtonRef.GetComponent<ButtonInfo>().ItemID];
            shopItems[3,ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            // CoinsTXT.text = "Baacks:" +totalbaacks.ToString();
            ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3,ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();

            if((shopItems[1,ButtonRef.GetComponent<ButtonInfo>().ItemID])==1)
            {
                addCoins+=1;
            }
            else if((shopItems[1,ButtonRef.GetComponent<ButtonInfo>().ItemID])==2)
            {
                addCoins+=4f;
            }
            else if((shopItems[1,ButtonRef.GetComponent<ButtonInfo>().ItemID])==3)
            {
                addCoins+=10f;
            }
            else if((shopItems[1,ButtonRef.GetComponent<ButtonInfo>().ItemID])==4)
            {
                addCoins+=200f;
            }
        }


    }

}
