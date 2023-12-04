using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StateService : MonoBehaviour, IState
{
    public Status status;

    private float decreaseRate = 2f; // 1분에 감소하는 비율

    #region UI
    public Slider hungerSlide;
    public Slider thirstSlide;
        #endregion

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
            status.hunger -= decreaseRate * Time.deltaTime;
            status.thirst -= decreaseRate * Time.deltaTime;
            status.happiness -= decreaseRate * Time.deltaTime;

            if (status.hunger <= 0)
            {
                status.hunger = 0;
            }
            if (status.thirst <= 0)
            {
                status.thirst = 0;
            }
            if (status.happiness <= 0)
            {
                status.happiness = 0;
            }

            yield return null; // 한 프레임을 대기합니다.
        }
    }

    private IEnumerator StatusUI()
    {
        while (true)
        {

        }
    }
    #region 아이템 유형에 따른 스텟 변화
    public void TypeClassification(GameObject obj)
    {
        switch (obj.layer)
        {
            case (int)Definition.Water.Water:                
                Debug.Log("배고픔 PULL");
                break;
        }
    }

    public void SetAccordingType_Water(string name)
    {

    }
    #endregion

    #region Interface
    public float GetHungry() => status.Hunger;

    public void SetHungry(float hungry) => status.Hunger = status.HungerMax;
    public void AddHungry(float hungry) => status.Hunger += hungry;

    #endregion
}
