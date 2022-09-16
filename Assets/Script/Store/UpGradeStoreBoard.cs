using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UpGradeStoreBoard : MonoBehaviour
{
    #region Resource
    [SerializeField]
    [Tooltip("���� ���ҽ�")]
    protected Sprite storeResource;

    [SerializeField]
    [Tooltip("������ ���ҽ�")]
    protected List<Sprite> weaselResources = new List<Sprite>();

    [SerializeField]
    [Tooltip("��� ���ҽ�")]
    protected List<Sprite> equipmentResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("������ ������")]
    protected List<WeaselData> weaselDatas = new List<WeaselData>();

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

    [Tooltip("��°�?")]
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

    //���� ���ҽ�, ������, ���, ����Ʈ ���ҽ�,
    private void SetStore(EDessertType dessertType)
    {
        
    }

}