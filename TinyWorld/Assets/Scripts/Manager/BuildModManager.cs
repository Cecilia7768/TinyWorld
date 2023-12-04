using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildModManager : MonoBehaviour
{
    [SerializeField]
    private GameObject so;
    private bool issoProOn = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            if (issoProOn)
            {
                so.SetActive(false);
                issoProOn = false;
            }
            else
            {
                so.SetActive(true);
                issoProOn = true;
            }
        }
    }
}
