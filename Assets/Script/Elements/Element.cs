using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Element : MonoBehaviour
{
    #region UIs
    [SerializeField]
    [Tooltip("이름")]
    protected TextMeshProUGUI nameTxt;

    [SerializeField]
    [Tooltip("Icon Image")]
    protected Image imageIcon;


    [SerializeField]
    [Tooltip("비용")]
    protected TextMeshProUGUI costTxt;

    #endregion

    [SerializeField]
    protected BaseData data;

    public BaseData Data
    {
        get { return data; }
        set { data = value; }
    }

    protected virtual void Update()
    {

    }

    private void ApplyTexts()
    {
        nameTxt.text = $"{data.name}";
        imageIcon.sprite = data.icon;
        costTxt.text = $"{data.cost}";
    }
    protected virtual void OnEnable()
    {




    }
    /// <summary>
    /// BoardType에 따라 불러오는 데이터를 다르게 하는 함수
    /// </summary>
    /// <param name="type"></param>
    private void DiscriminateType(EBoardType type)
    {
        switch (type)
        {
            case EBoardType.Equipment:
                Data = (EquipmentData)UpGradeManager.Instance.datas[EBoardType.Equipment]
                       [(int)UpGradeManager.Instance.CurrentBoardType];
                break;
            case EBoardType.Store:
                Data = (StoreData)UpGradeManager.Instance.datas[EBoardType.Store]
                       [(int)UpGradeManager.Instance.CurrentBoardType];
                break;
            case EBoardType.Weasel:
                Data = (WeaselData)UpGradeManager.Instance.datas[EBoardType.Weasel]
                       [(int)UpGradeManager.Instance.CurrentBoardType];
                break;
        }
    }


    private void ApplyImage()
    {

    }

}
