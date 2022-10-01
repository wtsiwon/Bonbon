using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StoreData", menuName = "Datas/StoreData", order = 1)]
public class StoreData : BaseData
{
    [Tooltip("StoreSprite")]
    public List<Sprite> storeResource = new List<Sprite>();
    [Tooltip("현재 스탯")]
    public float currentStat;
    [Tooltip("삿냐")]
    public bool isBought;
    [Tooltip("족제비 애니메이션")]
    public GameObject weaselBack;
}
