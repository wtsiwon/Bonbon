using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Equipment", menuName = "EquipmentDatas", order = int.MinValue)]
public class EquipmentData : ScriptableObject
{
    public Stat stat;
    [Tooltip("����?")]
    public bool isBought;
    [Tooltip("���� �Ϸ� Sprite")]
    public Sprite boughtSprite;
}
