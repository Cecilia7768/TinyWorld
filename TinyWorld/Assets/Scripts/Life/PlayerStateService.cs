using Definition;
using System.Collections;
using UnityEngine;


public class PlayerStateService : MonoBehaviour, IState
{
    public Status status;     

    private float decreaseRate = 2f; // 1분에 감소하는 비율


    private void Start()
    {
        StartCoroutine(DecreaseStatus());
    }

    private void SetInit()
    {
        status.Happiness = status.HappinessMax;
    }

    private IEnumerator DecreaseStatus()
    {
        while (true)
        {
            // 1분(60초)에 해당 비율만큼 status 변수를 감소시킵니다.
            status.Hunger -= decreaseRate * Time.deltaTime;
            status.Thirst -= decreaseRate * Time.deltaTime;
            status.Happiness -= decreaseRate * Time.deltaTime;

            if (status.Hunger <= 0)
            {
                status.Hunger = 0;
            }
            if (status.Thirst <= 0)
            {
                status.Thirst = 0;
            }
            if (status.Happiness <= 0)
            {
                status.Happiness = 0;
            }

            yield return null; 
        }
    }


    #region 아이템 유형에 따른 스텟 변화
    public void TypeClassification(GameObject obj)
    {
        OBJCategory value;
        if (SystemManager.Instance.objData.TryGetValue(obj.tag, out value))
        {
            var t = value;
            switch (t)
            {
                case OBJCategory.None:
                    break;
                case OBJCategory.Basic:
                    //여기서 기본 아이템 중 어떤 분류인지로 나뉨
                    //카테고리별 액션이 들어가야함
                    TypeClass_BasicType(obj.layer);
                    break;
                case OBJCategory.Collect:
                    break;
            }
        }
    }

    /// <summary>
    /// Basic Objects
    /// 상수 부분 나중에 가시성있게 정리좀
    /// </summary>
    public void TypeClass_BasicType(int type)
    {
        switch (type)
        {
            case (int)ItemType.Water:
                ChangeThirst(30f);
                break;
        }
    }


    #endregion

    #region Interface
    public float GetHungry() => status.Hunger;
    public float GetThirst() => status.Thirst;

    // 허기 , 갈증 초기화 (MAX)
    public void SetHungry() => status.Hunger = status.HungerMax;
    public void SetThirst() => status.Thirst = status.ThirstMax;

    // 값 변경
    public void ChangeHungry(float value)
    {
        status.Hunger += value;
        if(status.Hunger > status.HungerMax)
            SetHungry();
    }
    public void ChangeThirst(float value)
    {
        status.Thirst += value;
        if(status.Thirst > status.ThirstMax)
            SetThirst();
    }
    #endregion    
}
