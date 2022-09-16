using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI Coin_Text;
    public TextMeshProUGUI Touch_Coin_Text;
    public TextMeshProUGUI Time_Coin_Text;

    void Start()
    {
        
    }

    void Update()
    {
        Text_Apply();
    }

    private void Text_Apply()
    {
        Coin_Text.text = "Coin : " + GameManager.Inst.Coin;
        Time_Coin_Text.text = "Time : " + GameManager.Inst.Time_Coin;
        Touch_Coin_Text.text = "Touch : " + GameManager.Inst.Touch_Coin;
    }

    public void Boss_Upgrade()
    {
        GameManager.Inst.Touch_Coin += 10;
    }
}
