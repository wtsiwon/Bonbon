using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaselData", menuName = "Datas/WeaselData", order = 2)]
public class WeaselData : BaseData
{
    [Header("Stat")]
    [Tooltip("����")]
    public Stat stat;
    [Tooltip("�߰� ��������")]
    public Stat buff;
    [Tooltip("�������� ���� ����")]
    public Stat statIncrement;

    [Space(20f)]
    [Tooltip("Type")]
    public EDessertType dessertType;
    [Tooltip("level")]
    public int level;
    [Tooltip("Cost")]
    public float cost;
    [Tooltip("�̸�")]
    public string name;
    [Tooltip("��°�")]
    public bool isBought;
    [Tooltip("������ Image")]
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