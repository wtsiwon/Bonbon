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
    #endregion
    
    [SerializeField]
    [Tooltip("����Ʈ�� ����")]
    protected EDessertType dessertType;

    #region UI
    [SerializeField]
    [Tooltip("������ ��ư")]
    protected Button exitBtn;
    [SerializeField]
    [Tooltip("")]
    private Image lockimg;
    #endregion

    [Tooltip("��°�?")]
    public bool isBought;


    //[SerializeField]
    //[Tooltip("������ ���ҽ�")]
    //protected List<Sprite> weaselResources = new List<Sprite>();

    #region GetComponentvalue
    //protected Animator animator;
    protected Image img;
    #endregion

    protected void Start()
    {
        //animator = GetComponent<Animator>();
        img = GetComponent<Image>();

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

    public void SetStore(EDessertType dessertType)
    {
        
        //���� ���ҽ�, ������, ���, ����Ʈ ���ҽ�, 
    }


}