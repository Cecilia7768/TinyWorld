using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject fruits;
    void OnMouseDown()
    {
        var anim = this.GetComponent<Animation>();
        anim.Play();
        if (fruits.activeSelf)
        {
            fruits.SetActive(false);
            SystemManager.Instance.inven.ChangeFoodCount(5);
        }
    }
}
