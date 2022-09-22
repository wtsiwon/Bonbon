using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Equipment : MonoBehaviour
{
    #region UI
    [SerializeField]
    [Tooltip("��� Image")]
    private Image equipmentImg;

    [SerializeField]
    [Tooltip("��� �����͵�")]
    private List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    [SerializeField]
    [Tooltip("��� ��� ��ư��")]
    public List<Button> buyBtns = new List<Button>();

    [SerializeField]
    [Tooltip("��� ���ҽ�")]
    private List<Sprite> equipmentResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("Sprite�� ������ ImageComponent")]
    private List<Image> equipmentImage = new List<Image>();
    #endregion

    [SerializeField]
    private EquipmentData data;
    public EquipmentData Data
    {
        get
        {
            return data;
        }
        set
        {
            data = value;
        }
    }

}
