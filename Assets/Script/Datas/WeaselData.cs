using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaselData", menuName = "Datas/WeaselData", order = 2)]
public class WeaselData : BaseData
{
    [Header("Stat")]
    [Tooltip("스탯")]
    public Stat stat;
    [Tooltip("추가 버프스탯")]
    public Stat buff;
    [Tooltip("레벨업시 증가 스탯")]
    public Stat statIncrement;

    [Space(20f)]
    [Tooltip("Type")]
    public EDessertType dessertType;
    [Tooltip("level")]
    public int level;
    [Tooltip("Cost")]
    public float cost;
    [Tooltip("이름")]
    public string name;
    [Tooltip("삿는가")]
    public bool isBought;
    [Tooltip("족제비 Image")]
    public Sprite weaselImage;
}

//public class CakeWeaselData : WeaselData
//{
//    public ECakeType type;
//}
//public class CookieWeaselData : WeaselData 
//{ 
//    public ECookieType type;
//}

//public class MacaronWeaselData : WeaselData
//{
//    public EMacaronType type;
//}

//public class ShavedIceWeaselData : WeaselData
//{
//    public EShavedIceType type;
//}
//public class PuddingWeaselData : WeaselData
//{
//    public EPuddingType type;
//}