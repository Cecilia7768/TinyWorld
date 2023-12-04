
using UnityEngine;

public interface IState
{
    public float GetHungry();



    public void SetHungry(float hungry); //배고픔 세팅 초기화 용도
    public void AddHungry(float hungry);

    //////////////////////////////////////


    public void TypeClassification(GameObject obj); //클릭한 아이템 유형에 따른 스텟 변화
}