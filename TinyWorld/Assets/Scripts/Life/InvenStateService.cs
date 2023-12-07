using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InvenStateService : MonoBehaviour, IInventoryState
{
    public InventoryStatus status;


    #region Interface
    public float GetFoodCount() => status.FoodCount;

    public float GetWaterCount() => status.WaterCount;

    //public void SetFoodCount(int value) => status.FoodCount = value;    

    //public void SetWaterCount(int value)
    //{
    //    throw new System.NotImplementedException();
    //}

    public void ChangeFoodCount(int value) => status.FoodCount += value;
    public void ChangeWaterCount(int value) => status.WaterCount += value;
    #endregion
}
