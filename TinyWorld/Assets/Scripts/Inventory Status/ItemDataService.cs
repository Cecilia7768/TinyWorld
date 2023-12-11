using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

/// <summary>
/// 채집 , 수렵 상호작용 시 
/// </summary>
namespace Definition
{
    public class ItemDataService : MonoBehaviour,IItemContainer
    {
        [SerializeField]
        private GameObject product;

        public ItemInfo itemInfo;

        private void OnMouseDown()
        {
            var anim = this.GetComponent<Animation>();
            anim.Play();
            if (product.activeSelf)
            {
                product.SetActive(false);
                AddItemList();
                SystemManager.Instance.inven.ChangeFoodCount(5);
            }           
        }

        private void Start()
        {
            StartCoroutine(ResetProduct());
        }
        public void AddItemList()
        {
            int idx = ItemContainer.itemList.FindIndex(item => item.Name == this.itemInfo.Name);
            if (idx != -1)
            {
                var item = ItemContainer.itemList[idx];
                item.HaveCount += item.AddCount;
                ItemContainer.itemList[idx] = item;
                ItemSlot.ItemChanged(item.HaveCount.ToString());
            }
            else
            {
                ItemContainer.itemList.Add(new ItemInfo { 
                    Img = this.itemInfo.Img,
                    Name = this.itemInfo.Name,
                    AddCount = this.itemInfo.AddCount,
                    HaveCount = this.itemInfo.AddCount,
                    Type = this.itemInfo.Type
                });
            }

            SaveItemList(ItemContainer.itemList);
        }

        public void SaveItemList(List<ItemInfo> itemList)
        {
            string json = JsonUtility.ToJson(new Serialization<ItemInfo>(itemList));
            PlayerPrefs.SetString("itemList", json);
            PlayerPrefs.Save();
        }

        private IEnumerator ResetProduct()
        {
            while(true)
            {
                yield return new WaitForSeconds(this.itemInfo.ReloadTime);
                if(!product.activeSelf)
                    product.SetActive(true);
            }
        }
    }
}