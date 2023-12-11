using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Definition
{
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

    [System.Serializable]
    public struct ItemInfo
    {
        public Sprite img;
        public string name;
        public int addCount;
        public int haveCount;

        public float reloadTime;
        public ItemType type;
        public Sprite Img
        {
            get { return img; }
            set { img = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }      
        public int AddCount
        {
            get { return addCount; }
            set { addCount = value; }
        }       
        public int HaveCount
        {
            get { return haveCount; }
            set { haveCount = value; }
        }
        public float ReloadTime
        {
            get { return reloadTime; }
            set { reloadTime = value; }
        }
        public ItemType Type
        {
            get { return type; }
            set { type = value; }
        }
    }

    [System.Serializable]
    public class Serialization<T>
    {
        [SerializeField]
        private List<T> target;
        public List<T> ToList() => target;

        public Serialization(List<T> target)
        {
            this.target = target;
        }
    }

}