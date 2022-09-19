using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentStoreBoard : MonoBehaviour
{

    [SerializeField]
    [Tooltip("��� �����͵�")]
    private List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    [SerializeField]
    [Tooltip("��� ��� ��ư��")]
    public List<Button> buyBtns = new List<Button>();

    [SerializeField]
    [Tooltip("��� ���ҽ�")]
    private List<Sprite> equipmentResource = new List<Sprite>();

    [SerializeField]
    [Tooltip("Sprite�� ������ ImageComponent")]
    private List<Image> equipmentImage = new List<Image>();

    private void OnEnable()
    {
        StartCoroutine(ISetEquipment());
    }
    private IEnumerator ISetEquipment()
    {
        yield return new WaitForSeconds(0.1f);
        SetEquipment(UpGradeManager.Instance.currentBoardType);
    }

    private void SetEquipment(EDessertType dessertType)
    {
        
    }

    private void SetEquipmentBuyBtn()
    {
        for (int i = 0; i < buyBtns.Count; i++)
        {
            int a = i;
            buyBtns[a].onClick.AddListener(() =>
            {
                equipmentDatas[a].isBought = true;
            });
        }
    }
    
    private void SetEquipmentImage(EDessertType dessertType)
    {
        for (int i = 0; i < equipmentImage.Count; i++)
        {
            equipmentImage[i].sprite = equipmentResource[i];
        }
    }

    private void SetEquipmentDatas(EDessertType dessertType)
    {

    }
}
