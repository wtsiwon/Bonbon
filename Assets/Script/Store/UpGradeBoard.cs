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
    [Tooltip("���� ���")]
    protected Sprite storeBackGround;

    #endregion
    [SerializeField]
    [Tooltip("����Ʈ�� ����")]
    protected EDessertType dessertType;

    #region UI
    [Header("Buttons")]
    [SerializeField]
    [Space(20f)]
    [Tooltip("���� ����â ��ư")]
    protected Button storeUpBoardBtn;

    [SerializeField]
    [Tooltip("������ ����â ��ư")]
    protected Button weaselUpBoardBtn;

    [SerializeField]
    [Tooltip("��� ��� â ��ư")]
    protected Button equipmentStoreBoardBtn;

    [SerializeField]
    [Tooltip("������ ��ư")]
    protected Button exitBtn;
    #endregion

    #region Boards
    [Header("Boards")]
    [SerializeField]
    [Space(20f)]
    [Tooltip("���� ����â")]
    private StoreUpBoard storeUpBoard;

    [SerializeField]
    [Tooltip("������ ����â")]
    private WeaselUpBoard weaselUpBoard;

    [SerializeField]
    [Tooltip("��� ����â")]
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
    /// Type�� ���� ���� ���� �ִ� ���ִ� �Լ�
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

    //���� ���ҽ�, ������, ���, ����Ʈ ���ҽ�, ���� Data
    private void SetStore(EDessertType dessertType)
    {
        
    }

}