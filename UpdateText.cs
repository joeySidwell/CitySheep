using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    
    public ShopManagerScript shopManager;
    public GameManager gameManager;
    public Text CoinsTXT;
    public float totalCoins;
    
        // Start is called before the first frame update
    public void Text()
    {
        totalCoins = shopManager.coins+gameManager.finalCoins;
        CoinsTXT.text = "Baacks:" + (totalCoins).ToString();
    }
}
