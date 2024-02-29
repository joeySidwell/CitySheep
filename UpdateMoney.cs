using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateMoney : MonoBehaviour
{
    public TMP_Text moneyText;
    private int money;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney()
    {
        money++;
        moneyText.text = "Baacks: " + money;
    }
}
