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
    #endregion
    
    [SerializeField]
    [Tooltip("디저트의 종류")]
    protected EDessertType dessertType;

    #region UI
    [SerializeField]
    [Tooltip("나가기 버튼")]
    protected Button exitBtn;
    [SerializeField]
    [Tooltip("")]
    private Image lockimg;
    #endregion

    [Tooltip("샀는가?")]
    public bool isBought;


    //[SerializeField]
    //[Tooltip("족제비 리소스")]
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
        
        //가게 리소스, 족제비, 장비, 디저트 리소스, 
    }


}