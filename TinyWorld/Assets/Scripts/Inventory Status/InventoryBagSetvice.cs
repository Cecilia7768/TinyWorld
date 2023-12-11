using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Definition;
using System;

public class InventoryBagSetvice : MonoBehaviour
{
    [SerializeField]
    private GameObject slot;

    private void OnEnable()
    {
        UpdateInventoryUI();
    }

    private void OnDisable()
    {
        ClearInventoryUI();
    }

    private void UpdateInventoryUI()
    {
        if (ItemContainer.itemList != null)
        {
            for (int i = 0; i < ItemContainer.itemList.Count; i++)
            {
                var obj = Instantiate(slot, this.transform);
                var slotInfo = obj.GetComponent<ItemSlot>();
                slotInfo.SetInfo(ItemContainer.itemList[i]);
            }
        }
    }
    private void ClearInventoryUI()
    {
        foreach (Transform child in this.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
