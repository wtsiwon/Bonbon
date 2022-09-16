using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UpGradeStoreBoard : MonoBehaviour
{
    #region Resource
    [SerializeField]
    [Tooltip("가게 리소스")]
    protected Sprite storeResource;

    [SerializeField]
    [Tooltip("족제비 리소스")]
    protected List<Sprite> weaselResources = new List<Sprite>();

    [SerializeField]
    [Tooltip("장비 리소스")]
    protected List<Sprite> equipmentResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("족제비 데이터")]
    protected List<WeaselData> weaselDatas = new List<WeaselData>();

    [SerializeField]
    [Tooltip("장비 데이터")]
    protected List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    #endregion

    [SerializeField]
    [Tooltip("디저트의 종류")]
    protected EDessertType dessertType;

    #region UI
    [SerializeField]
    [Tooltip("가게 업글창 버튼")]
    protected Button storeUpBoardBtn;

    [SerializeField]
    [Tooltip("족제비 업글창 버튼")]
    protected Button weaselUpBoardBtn;

    [SerializeField]
    [Tooltip("장비 사는 창 버튼")]
    protected Button equipmentStoreBoardBtn;

    [SerializeField]
    [Tooltip("나가기 버튼")]
    protected Button exitBtn;
    #endregion

    [Tooltip("샀는가?")]
    public bool isBought;

    #region GetComponentvalue
    //protected Animator animator;
    #endregion

    protected virtual void Start()
    {
        exitBtn.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });

        //animator = GetComponent<Animator>();
    }

    public EDessertType DessertType
    {
        get
        {
            return dessertType;
        }
        set
        {
            dessertType = value;

        }
    }

    //가게 리소스, 족제비, 장비, 디저트 리소스,
    private void SetStore(EDessertType dessertType)
    {
        
    }

}