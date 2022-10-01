using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StoreData", menuName = "Datas/StoreData", order = 1)]
public class StoreData : BaseData
{
    [Tooltip("StoreSprite")]
    public List<Sprite> storeResource = new List<Sprite>();
    [Tooltip("���� ����")]
    public float currentStat;
    [Tooltip("���")]
    public bool isBought;
    [Tooltip("������ �ִϸ��̼�")]
    public GameObject weaselBack;
}
