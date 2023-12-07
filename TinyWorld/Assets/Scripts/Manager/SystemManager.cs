using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using SoulGames.Utilities;
using SoulGames.EasyGridBuilderPro;
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
    }

    private void SetOBJData()
    {
        objData["None"] = Definition.OBJCategory.None;
        objData["Basic"] = Definition.OBJCategory.Basic;
    }
}
