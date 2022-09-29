using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Element : MonoBehaviour
{
    #region UIs
    [SerializeField]
    [Tooltip("�̸�")]
    protected TextMeshProUGUI nameTxt;

    [SerializeField]
    [Tooltip("Icon Image")]
    protected Image imageIcon;


    [SerializeField]
    [Tooltip("���")]
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
    /// BoardType�� ���� �ҷ����� �����͸� �ٸ��� �ϴ� �Լ�
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
