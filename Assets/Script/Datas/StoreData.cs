using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StoreData", menuName = "Datas/StoreData", order = 1)]
public class StoreData : BaseData
{
    [Tooltip("����")]
    public Stat stat;
    [Tooltip("StoreSprite")]
    public List<Sprite> storeResource = new List<Sprite>();
    [Tooltip("���׷��̵� ���")]
    public float cost;
    [Tooltip("���۽� ���� ������")]
    public Stat statIncrement;
    [Tooltip("����")]
    public float level;
    [Tooltip("���� ����")]
    public float currentStat;
    [Tooltip("���")]
    public bool isBought;
    [Tooltip("�̸�")]
    public string name;
    [Tooltip("������ �ִϸ��̼�")]
    public GameObject weaselBack;
}
