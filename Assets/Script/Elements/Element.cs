using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Element : MonoBehaviour
{
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



    protected virtual void Update()
    {
        
    }

    private void ApplyTexts()
    {

    }

}
