using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Definition;


public class UISystem : MonoBehaviour
{
    public Slider hungerSlide;
    public Slider thirstSlide;
    
    [SerializeField]
    private TMP_Text foodCountTxt;
    [SerializeField]
    private TMP_Text waterCountTxt;
    [SerializeField]
    private GameObject bag;
    private void Start()
    {
        StartCoroutine(StatusUI());
        StartCoroutine(InvenUI());
    }

    private void Init()
    {
        foodCountTxt.text = SystemManager.Instance.iInventoryState.GetFoodCount().ToString();
        waterCountTxt.text = SystemManager.Instance.iInventoryState.GetWaterCount().ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            bag.SetActive(!bag.activeSelf);
        }
    }
    private IEnumerator StatusUI()
    {
        while (true)
        {
            hungerSlide.value = SystemManager.Instance.istate.GetHungry() / 100.0f;
            thirstSlide.value = SystemManager.Instance.istate.GetThirst() / 100.0f;
            yield return null;
        }
    }
    private IEnumerator InvenUI()
    {
        while (true)
        {
            foodCountTxt.text = SystemManager.Instance.iInventoryState.GetFoodCount().ToString();
            waterCountTxt.text = SystemManager.Instance.iInventoryState.GetWaterCount().ToString();
            yield return null;
        }
    }

}

