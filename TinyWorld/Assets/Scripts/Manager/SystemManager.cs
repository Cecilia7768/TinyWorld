using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using SoulGames.Utilities;
using SoulGames.EasyGridBuilderPro;
using Definition;
public class SystemManager : MonoBehaviour
{
    #region Singleton
    private static SystemManager instance;
    public static SystemManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SystemManager>();
            }
            return instance;
        }
    }
    #endregion

    public PlayerStateService player;
    public InvenStateService inven;

    public IState istate;
    public IInventoryState iInventoryState;

    public Dictionary<string, Definition.OBJCategory> objData = new Dictionary<string, Definition.OBJCategory>();

    private void Awake()
    {
        SetInit();       
    }


    private void SetInit()
    {
        istate = player.GetComponent<IState>();
        iInventoryState = inven.GetComponent<IInventoryState>();
        SetOBJData();

        ///���߿� �Ⱦ��� ����� 
        iInventoryState.SetFoodCount(LoadFoodCount());
        iInventoryState.SetWaterCount(LoadWaterCount());

        ItemContainer.itemList = LoadItemList();
    }

    private void SetOBJData()
    {
        objData["None"] = Definition.OBJCategory.None;
        objData["Basic"] = Definition.OBJCategory.Basic;
    }

    #region �ε�_ ���߿� �����Ƽ�� �����Ұ��� (�ӽ�)
    public int LoadFoodCount()
    {
        return PlayerPrefs.GetInt("FoodCount", 0);
    }

    public int LoadWaterCount()
    {
        return PlayerPrefs.GetInt("WaterCount", 0);
    }

    public static List<ItemInfo> LoadItemList()
    {
        if (PlayerPrefs.HasKey("itemList"))
        {
            string json = PlayerPrefs.GetString("itemList");
            return JsonUtility.FromJson<Serialization<ItemInfo>>(json).ToList();
        }
        return new List<ItemInfo>();
    }

    #endregion
}
