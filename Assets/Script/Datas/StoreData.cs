using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StoreData", menuName = "Datas/StoreData", order = 1)]
public class StoreData : ScriptableObject
{
    [Tooltip("����")]
    public Stat stat;
    [Tooltip("StoreSprite")]
    public Sprite sprite;
    [Tooltip("���׷��̵� ���")]
    public float cost;
    [Tooltip("���۽� ���� ������")]
    public float statIncrement;
    [Tooltip("����")]
    public float level;
    [Tooltip("���� ����")]
    public float currentStat;
    [Tooltip("�̸�")]
    public string name;
}
