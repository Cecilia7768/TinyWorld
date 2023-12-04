[System.Serializable]
public struct Status
{
    public float hunger;   // 굶주림
    public float hungerMax;
    public float thirst;   // 갈증
    public float thirstMax;
    public float happiness; // 행복도
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