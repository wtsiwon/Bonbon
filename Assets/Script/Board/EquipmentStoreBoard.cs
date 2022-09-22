using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentStoreBoard : MonoBehaviour
{

    [SerializeField]
    [Tooltip("¿Â∫ÒµÈ")]
    private List<Equipment> equipments = new List<Equipment>();

    private void OnEnable()
    {
        StartCoroutine(ISetEquipment());
    }
    private IEnumerator ISetEquipment()
    {
        yield return new WaitForSeconds(0.1f);
        SetEquipment(UpGradeManager.Instance.CurrentBoardType);
    }

    private void SetEquipment(EDessertType dessertType)
    {
        
    }

    //private void SetEquipmentBuyBtn()
    //{
    //    for (int i = 0; i < buyBtns.Count; i++)
    //    {
    //        int a = i;
    //        buyBtns[a].onClick.AddListener(() =>
    //        {
    //            equipmentDatas[a].isBought = true;
    //        });
    //    }
    //}
    
    //private void SetEquipmentImage(EDessertType dessertType)
    //{
    //    for (int i = 0; i < equipmentImage.Count; i++)
    //    {
    //        equipmentImage[i].sprite = equipmentResource[i];
    //    }
    //}

    private void SetEquipmentDatas(EDessertType dessertType)
    {

    }
}
