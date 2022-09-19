using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaselUpBoard : MonoBehaviour
{
    #region ������ ���ҽ�
    [SerializeField]
    [Tooltip("����ũ ������ ���ҽ�")]
    private List<Sprite> cakeWeaselResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("��Ű ������ ���ҽ�")]
    private List<Sprite> cookieWeaselResource = new List<Sprite>();
    //�ٸ� ���ҽ� �߰� ����
    #endregion

    [SerializeField]
    [Tooltip("������ ����â�� ���ִ� ��ư")]
    private Button ActiveBtn;

    #region ������s
    [SerializeField]
    [Tooltip("������ ��")]
    protected List<Weasel> weasels = new List<Weasel>();
    #endregion

    public Dictionary<EDessertType, List<Sprite>> weasekResourceDic = new Dictionary<EDessertType, List<Sprite>>();


    private void Start()
    {
        
    }

    private void AddListners()
    {
        ActiveBtn.onClick.AddListener(() =>
        {
            
        });
    }

}
