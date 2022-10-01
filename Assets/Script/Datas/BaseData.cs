using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseData : ScriptableObject
{
    #region datas
    [Tooltip("올라가는 Stat")]
    public Stat stat;
    [Tooltip("비용")]
    public int cost;
    [Tooltip("이름")]
    public string name;
    [Tooltip("level")]
    public int level;
    [Tooltip("Icon")]
    public Sprite icon;
    [Tooltip("잠금Sprite")]
    public Sprite lockSprite;
    [Tooltip("업글시 스탯 증가량")]
    public Stat statIncrement;
    #endregion
}
