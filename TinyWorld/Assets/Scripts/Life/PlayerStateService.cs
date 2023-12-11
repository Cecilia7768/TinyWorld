using Definition;
using System.Collections;
using UnityEngine;


public class PlayerStateService : MonoBehaviour, IState
{
    public Status status;     

    private float decreaseRate = 2f; // 1�п� �����ϴ� ����


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


    #region ������ ������ ���� ���� ��ȭ
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
                    //���⼭ �⺻ ������ �� � �з������� ����
                    //ī�װ��� �׼��� ������
                    TypeClass_BasicType(obj.layer);
                    break;
                case OBJCategory.Collect:
                    break;
            }
        }
    }

    /// <summary>
    /// Basic Objects
    /// ��� �κ� ���߿� ���ü��ְ� ������
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

    // ��� , ���� �ʱ�ȭ (MAX)
    public void SetHungry() => status.Hunger = status.HungerMax;
    public void SetThirst() => status.Thirst = status.ThirstMax;

    // �� ����
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
