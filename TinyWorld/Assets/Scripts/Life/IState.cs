using UnityEngine;

public interface IState
{
    public float GetHungry();
    public float GetThirst();

    public void SetHungry(); //��� ���� �ʱ�ȭ �뵵
    public void SetThirst(); //���� ���� �ʱ�ȭ �뵵

    public void ChangeHungry(float value);
    public void ChangeThirst(float value);

    //////////////////////////////////////


    public void TypeClassification(GameObject obj); //Ŭ���� ������ ������ ���� ���� ��ȭ
}

