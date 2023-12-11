using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Definition;

/// <summary>
/// ��ü ��� ����
/// </summary>
public class InvenStateService : MonoBehaviour, IInventoryState
{
    public InventoryStatus status;


    #region Interface
    public float GetFoodCount() => status.FoodCount;
    public float GetWaterCount() => status.WaterCount;


    public void SetFoodCount(int value) => status.FoodCount = value;

    public void SetWaterCount(int value) => status.WaterCount = value;

    public void ChangeFoodCount(int value)
    {
        status.FoodCount += value;
        SaveFoodCount(status.FoodCount);
    }
    public void ChangeWaterCount(int value)
    {
        status.WaterCount += value;
        SaveWaterCount(status.WaterCount);

    }
    #endregion


    #region ���̺�ε�(�ӽ�) ���߿� �����Ƽ�� �����Ұ���
    public void SaveFoodCount(int foodCount)
    {
        PlayerPrefs.SetInt("FoodCount", foodCount);
        PlayerPrefs.Save();
    }    
    public void SaveWaterCount(int waterCount)
    {
        PlayerPrefs.SetInt("WaterCount", waterCount);
        PlayerPrefs.Save();
    }
    #endregion
}
