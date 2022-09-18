using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentStoreBoard : MonoBehaviour
{
    [SerializeField]
    [Tooltip("장비 데이터들")]
    private List<EquipmentData> equipmentDatas = new List<EquipmentData>();

    [SerializeField]
    [Tooltip("장비 사는 버튼들")]
    public List<Button> buyBtns = new List<Button>();

    [SerializeField]
    [Tooltip("장비 리소스")]
    private List<Sprite> equipmentResource = new List<Sprite>();

    private void OnEnable()
    {
        StartCoroutine(ISetEquipment());
    }
    private IEnumerator ISetEquipment()
    {
        yield return new WaitForSeconds(0.1f);
        SetEQuipment(UpGradeManager.Instance.currentBoardType);
    }

    private void SetEQuipment(EDessertType dessertType)
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
}
