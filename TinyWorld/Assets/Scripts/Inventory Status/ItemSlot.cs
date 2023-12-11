using Definition;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public GameObject icon;
    public Sprite iconSprite;
    public TMP_Text numTxt;

    public static event Action<string> OnItemChanged;

    private void Awake()
    {
        iconSprite = icon.GetComponent<Sprite>();
        OnItemChanged += UndateCount;
    }

    public void SetInfo(ItemInfo itemInfo)
    {
        iconSprite = itemInfo.Img;
        numTxt.text = itemInfo.HaveCount.ToString();
    }

    public static void ItemChanged(string count)
    {
        OnItemChanged?.Invoke(count);
    }
    private void UndateCount(string count)
    {
        numTxt.text = count;
    }
}
