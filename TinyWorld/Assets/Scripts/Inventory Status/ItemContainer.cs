using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Definition;

namespace Definition
{
    /// <summary>
    /// 아이템 타입별 재고 관련
    /// </summary>
    public static class ItemContainer 
    {
        public static List<ItemInfo> itemList = new List<ItemInfo>();
    }

}

public interface IItemContainer
{
    public void AddItemList();

    public void SaveItemList(List<ItemInfo> itemList);
}

