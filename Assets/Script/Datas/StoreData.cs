using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StoreData", menuName = "Datas/StoreData", order = 1)]
public class StoreData : BaseData
{
    [Tooltip("스탯")]
    public Stat stat;
    [Tooltip("StoreSprite")]
    public List<Sprite> storeResource = new List<Sprite>();
    [Tooltip("업그레이드 비용")]
    public float cost;
    [Tooltip("업글시 스탯 증가량")]
    public Stat statIncrement;
    [Tooltip("레벨")]
    public float level;
    [Tooltip("현재 스탯")]
    public float currentStat;
    [Tooltip("삿냐")]
    public bool isBought;
    [Tooltip("이름")]
    public string name;
    [Tooltip("족제비 애니메이션")]
    public GameObject weaselBack;
}
