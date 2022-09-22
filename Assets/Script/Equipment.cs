using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Equipment : MonoBehaviour
{
    #region UI
    [SerializeField]
    [Tooltip("장비 Image")]
    private Image equipmentImg;

    [SerializeField]
    [Tooltip("장비 데이터들")]
    private List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    [SerializeField]
    [Tooltip("장비 사는 버튼들")]
    public List<Button> buyBtns = new List<Button>();

    [SerializeField]
    [Tooltip("장비 리소스")]
    private List<Sprite> equipmentResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("Sprite를 적용할 ImageComponent")]
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
