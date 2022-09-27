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
    protected TextMeshProUGUI name;

    [SerializeField]
    [Tooltip("IconSprite")]
    protected Sprite iconSprite;

    [SerializeField]
    [Tooltip("Sprite가 들어갈 Image")]
    protected Image imageCom;

    [SerializeField]
    [Tooltip("클릭당 생산량")]
    protected TextMeshProUGUI clickIncrementTxt;

    [SerializeField]
    [Tooltip("초당 생산량")]
    protected TextMeshProUGUI secondIncrementTxt;

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

    protected virtual void OnEnable()
    {
        
        

        
    }

    private void DiscriminateType(EBoardType type)
    {
        switch (type)
        {
            case EBoardType.Equipment:
                Data = (EquipmentData)UpGradeManager.Instance.datas[EBoardType.Equipment]
        [(int)UpGradeManager.Instance.CurrentBoardType];
                break;
        }
    }

    private void ApplyTexts()
    {

    }

    private void ApplyImage()
    {

    }

}
