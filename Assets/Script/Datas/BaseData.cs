using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseData : ScriptableObject
{
    #region datas
    [Tooltip("�ö󰡴� Stat")]
    public Stat stat;
    [Tooltip("���")]
    public int cost;
    [Tooltip("�̸�")]
    public string name;
    [Tooltip("level")]
    public int level;
    [Tooltip("Icon")]
    public Sprite icon;
    [Tooltip("���Sprite")]
    public Sprite lockSprite;
    [Tooltip("���۽� ���� ������")]
    public Stat statIncrement;
    #endregion
}
