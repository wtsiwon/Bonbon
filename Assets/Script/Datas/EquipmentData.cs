using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EquipmentData", menuName = "Datas/EquipmentData", order = 0)]
public class EquipmentData : BaseData
    //장비는 가게의 능력치를 %로 증가 시킵니다
{
    [Tooltip("삿음?")]
    public bool isBought;
    [Tooltip("구매 완료 Sprite")]
    public Sprite boughtSprite;
    [Tooltip("장비 Sprite")]
    public Sprite equipmentSprite;
}
