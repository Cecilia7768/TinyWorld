[System.Serializable]
public struct Status
{
    public float hunger;   // ���ָ�
    public float hungerMax;
    public float thirst;   // ����
    public float thirstMax;
    public float happiness; // �ູ��
    public float happinessMax;
    public float Hunger
    {
        get { return hunger; }
        set { hunger = value; }
    }
    public float HungerMax
    {
        get { return hungerMax; }
    }
    public float Thirst
    {
        get { return thirst; }
        set { thirst = value; }
    }
    public float ThirstMax
    {
        get { return thirstMax; }
    }
    public float Happiness
    {
        get { return happiness; }
        set { happiness = value; }
    }
    public float HappinessMax
    {
        get { return happinessMax; }
    }
}

[System.Serializable]
public struct InventoryStatus
{
    public int foodCount;
    public int waterCount;

    public int FoodCount
    {
        get { return foodCount; }
        set { foodCount = value; }
    }  
    public int WaterCount
    {
        get { return waterCount; }
        set { waterCount = value; }
    }

}