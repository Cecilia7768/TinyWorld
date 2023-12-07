using Definition;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
    private Camera mainCamera; // 메인 카메라
    private void Start()
    {
        mainCamera = Camera.main; // 메인 카메라 설정
    }

    private void Update()
    {
        // 마우스 왼쪽 버튼이 클릭되었을 때
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // 레이캐스트를 통해 물체 감지
            if (Physics.Raycast(ray, out hit))
            {
                // 감지된 물체의 이름을 디버그 로그로 출력
                Debug.Log("클릭한 물체: " + hit.collider.gameObject.layer);
                SystemManager.Instance.istate.TypeClassification(hit.collider.gameObject);                

                //hit.collider.gameObject.layer;
            }
        }
    }
}
