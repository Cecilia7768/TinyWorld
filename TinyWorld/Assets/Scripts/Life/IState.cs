
using UnityEngine;

public interface IState
{
    public float GetHungry();



    public void SetHungry(float hungry); //����� ���� �ʱ�ȭ �뵵
    public void AddHungry(float hungry);

    //////////////////////////////////////


    public void TypeClassification(GameObject obj); //Ŭ���� ������ ������ ���� ���� ��ȭ
}