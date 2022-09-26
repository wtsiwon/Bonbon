using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Element : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�̸�")]
    protected TextMeshProUGUI name;

    [SerializeField]
    [Tooltip("IconSprite")]
    protected Sprite iconSprite;

    [SerializeField]
    [Tooltip("Sprite�� �� Image")]
    protected Image imageCom;

    [SerializeField]
    [Tooltip("Ŭ���� ���귮")]
    protected TextMeshProUGUI clickIncrementTxt;

    [SerializeField]
    [Tooltip("�ʴ� ���귮")]
    protected TextMeshProUGUI secondIncrementTxt;

    [SerializeField]
    [Tooltip("���")]
    protected TextMeshProUGUI costTxt;



    protected virtual void Update()
    {
        
    }

    private void ApplyTexts()
    {

    }

}
