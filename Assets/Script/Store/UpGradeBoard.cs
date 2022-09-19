using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EBoardType
{
    Store,
    Weasel,
    Equipment,
}

public  class UpGradeBoard : MonoBehaviour
{
    #region Resource
    [SerializeField]
    [Tooltip("가게 배경")]
    protected Sprite storeBackGround;

    #endregion
    [SerializeField]
    [Tooltip("디저트의 종류")]
    protected EDessertType dessertType;

    #region UI
    [Header("Buttons")]
    [SerializeField]
    [Space(20f)]
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

    #region Boards
    [Header("Boards")]
    [SerializeField]
    [Space(20f)]
    [Tooltip("가게 업글창")]
    private StoreUpBoard storeUpBoard;

    [SerializeField]
    [Tooltip("족제비 업글창")]
    private WeaselUpBoard weaselUpBoard;

    [SerializeField]
    [Tooltip("장비 구매창")]
    private EquipmentStoreBoard equipmentStoreBoard;
    #endregion

    #region GetComponentvalue

    #endregion

    protected virtual void Start()
    {
        #region OnClickAddListener
        //exitBtn.onClick.AddListener(() =>
        //{
        //    gameObject.SetActive(false);
        //    UpGradeManager.Instance.isActive = false;
        //});

        storeUpBoardBtn.onClick.AddListener(() =>
        {
            SetActiveBoard(EBoardType.Store);
        });

        weaselUpBoardBtn.onClick.AddListener(() =>
        {
            SetActiveBoard(EBoardType.Weasel);
        });

        equipmentStoreBoardBtn.onClick.AddListener(() =>
        {
            SetActiveBoard(EBoardType.Equipment);
        });


        #endregion
    }

    protected virtual void OnEnable()
    {
        SetStore(DessertType);
    }

    /// <summary>
    /// Type에 따라 보드 껏다 켯다 해주는 함수
    /// </summary>
    /// <param name="type"></param>
    private void SetActiveBoard(EBoardType type)
    {
        switch (type)
        {
            case EBoardType.Store:
                storeUpBoard.gameObject.SetActive(true);
                weaselUpBoard.gameObject.SetActive(false);
                equipmentStoreBoard.gameObject.SetActive(false);
                break;
            case EBoardType.Weasel:
                storeUpBoard.gameObject.SetActive(false);
                weaselUpBoard.gameObject.SetActive(true);
                equipmentStoreBoard.gameObject.SetActive(false);
                break;
            case EBoardType.Equipment:
                storeUpBoard.gameObject.SetActive(false);
                weaselUpBoard.gameObject.SetActive(false);
                equipmentStoreBoard.gameObject.SetActive(true);
                break;
            default:
                Debug.Assert(false);
                break;
        }
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

    //가게 리소스, 족제비, 장비, 디저트 리소스, 가게 Data
    private void SetStore(EDessertType dessertType)
    {
        
    }

}