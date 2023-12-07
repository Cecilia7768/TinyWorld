
using UnityEngine;

public interface IState
{
    public float GetHungry();
    public float GetThirst();

    public void SetHungry(); //허기 세팅 초기화 용도
    public void SetThirst(); //갈증 세팅 초기화 용도

    public void ChangeHungry(float value);   
    public void ChangeThirst(float value);

    //////////////////////////////////////


    public void TypeClassification(GameObject obj); //클릭한 아이템 유형에 따른 스텟 변화
}

public interface IInventoryState
{
    public float GetFoodCount();
    public float GetWaterCount();

    //public void SetFoodCount(int value);
    //public void SetWaterCount(int value);

    public void ChangeWaterCount(int value);
    public void ChangeFoodCount(int value);

}