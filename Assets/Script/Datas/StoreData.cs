using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StoreData", menuName = "Datas/StoreData", order = 1)]
public class StoreData : ScriptableObject
{
    [Tooltip("스탯")]
    public Stat stat;
    [Tooltip("StoreSprite")]
    public Sprite sprite;
    [Tooltip("업그레이드 비용")]
    public float cost;
    [Tooltip("업글시 스탯 증가량")]
    public float statIncrement;
    [Tooltip("레벨")]
    public float level;
    [Tooltip("현재 스탯")]
    public float currentStat;
    [Tooltip("이름")]
    public string name;
}
