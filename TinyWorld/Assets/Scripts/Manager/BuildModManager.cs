using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using SoulGames.Utilities;
using SoulGames.EasyGridBuilderPro;

public class BuildModManager : MonoBehaviour
{
    [SerializeField]
    private GameObject so;
    private bool issoProOn = false;

    private void Start()
    {
        EasyGridBuilderPro.Instance.Test_GridLoad();
        so.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if (issoProOn)
            {
                so.SetActive(false);
                issoProOn = false;
            }
            else
            {
                so.SetActive(true);
                issoProOn = true;
            }
        }
    }
}
