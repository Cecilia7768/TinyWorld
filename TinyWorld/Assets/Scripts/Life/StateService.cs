using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StateService : MonoBehaviour, IState
{
    public Status status;

    private float decreaseRate = 2f; // 1�п� �����ϴ� ����

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
            // 1��(60��)�� �ش� ������ŭ status ������ ���ҽ�ŵ�ϴ�.
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

            yield return null; // �� �������� ����մϴ�.
        }
    }

    private IEnumerator StatusUI()
    {
        while (true)
        {

        }
    }
    #region ������ ������ ���� ���� ��ȭ
    public void TypeClassification(GameObject obj)
    {
        switch (obj.layer)
        {
            case (int)Definition.Water.Water:                
                Debug.Log("����� PULL");
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
