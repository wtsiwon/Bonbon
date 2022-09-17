using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UpGradeBoard : MonoBehaviour
{
    #region Resource
    [SerializeField]
    [Tooltip("���� ���")]
    protected Sprite storeBackGround;

    [SerializeField]
    [Tooltip("��� ���ҽ�")]
    protected List<Sprite> equipmentResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("��� ������")]
    protected List<EquipmentData> equipmentDatas = new List<EquipmentData>();
    #endregion

    [SerializeField]
    [Tooltip("����Ʈ�� ����")]
    protected EDessertType dessertType;

    #region UI
    [SerializeField]
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
    [SerializeField]
    [Tooltip("���� ����â")]
    private StoreUpBoard storeUpBoard;

    [SerializeField]
    [Tooltip("������ ����â")]
    private GameObject weaselUpBoard;

    [SerializeField]
    [Tooltip("��� ����â")]
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

    //���� ���ҽ�, ������, ���, ����Ʈ ���ҽ�,
    private void SetStore(EDessertType dessertType)
    {
        
    }

}