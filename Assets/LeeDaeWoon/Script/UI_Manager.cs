using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class UI_Manager : MonoBehaviour
{
    [Header("돈 텍스트")]
    public TextMeshProUGUI Coin_Text;
    public TextMeshProUGUI Touch_Coin_Text;
    public TextMeshProUGUI Time_Coin_Text;

    [Header("레벨")]
    public Text Boss_Level;



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
        Boss_Level.text = "Boss Lv : " + GameManager.Inst.Boss_Level;
        Time_Coin_Text.text = "Time : " + GameManager.Inst.Time_Coin;
        Touch_Coin_Text.text = "Touch : " + GameManager.Inst.Touch_Coin;
    }

    public void Boss_Upgrade()
    {
        if (GameManager.Inst.Boss_Level * 20 < GameManager.Inst.Coin)
        {
            GameManager.Inst.Coin -= GameManager.Inst.Boss_Level * 20;
            GameManager.Inst.Touch_Coin += 10;
            GameManager.Inst.Boss_Level += 1;
        }
    }


}
