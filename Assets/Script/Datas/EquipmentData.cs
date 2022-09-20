using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EquipmentData", menuName = "Datas/EquipmentData", order = 0)]
public class EquipmentData : BaseData
{
    [Tooltip("�ö󰡴� Stat")]
    public Stat stat;
    [Tooltip("����?")]
    public bool isBought;
    [Tooltip("���� �Ϸ� Sprite")]
    public Sprite boughtSprite;
    [Tooltip("��� Sprite")]
    public Sprite equipmentSprite;
    [Tooltip("����")]
    public float cost;
    [Tooltip("�̸�")]
    public string name;
}
