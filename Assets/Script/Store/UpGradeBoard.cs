using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UpGradeBoard : MonoBehaviour
{
    #region Resource
    [SerializeField]
    [Tooltip("가게 배경")]
    protected Sprite storeBackGround;

    [SerializeField]
    [Tooltip("장비 리소스")]
    protected List<Sprite> equipmentResource = new List<Sprite>();

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

    #region Boards
    [SerializeField]
    [Tooltip("가게 업글창")]
    private StoreUpBoard storeUpBoard;

    [SerializeField]
    [Tooltip("족제비 업글창")]
    private GameObject weaselUpBoard;

    [SerializeField]
    [Tooltip("장비 구매창")]
    private GameObject equipmentStoreBoard;
    #endregion

    #region GetComponentvalue

    #endregion

    protected virtual void Start()
    {
        #region OnClickAddListener
        exitBtn.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            UpGradeManager.Instance.isActive = false;
        });

        storeUpBoardBtn.onClick.AddListener(() =>
        {
            storeUpBoard.gameObject.SetActive(true);
        });

        weaselUpBoardBtn.onClick.AddListener(() =>
        {
            weaselUpBoard.gameObject.SetActive(true);
        });

        equipmentStoreBoardBtn.onClick.AddListener(() =>
        {
            equipmentStoreBoard.gameObject.SetActive(true);
        });


        #endregion
    }

    protected virtual void OnEnable()
    {
        SetStore(DessertType);
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