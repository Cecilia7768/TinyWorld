using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public GameObject player;
    public IState istate;

    private void Awake()
    {
        SetInit();
    }
    private void SetInit()
    {
        istate = player.GetComponent<IState>();
    }
}
