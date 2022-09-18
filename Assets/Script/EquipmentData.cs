using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Equipment", menuName = "EquipmentDatas", order = int.MinValue)]
public class EquipmentData : ScriptableObject
{
    public Stat stat;
    [Tooltip("삿음?")]
    public bool isBought;
    [Tooltip("구매 완료 Sprite")]
    public Sprite boughtSprite;
}
