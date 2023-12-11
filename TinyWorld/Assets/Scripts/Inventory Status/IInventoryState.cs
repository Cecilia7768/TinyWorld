public interface IInventoryState
{
    public float GetFoodCount();
    public float GetWaterCount();

    public void SetFoodCount(int value);
    public void SetWaterCount(int value);

    public void ChangeWaterCount(int value);
    public void ChangeFoodCount(int value);

}