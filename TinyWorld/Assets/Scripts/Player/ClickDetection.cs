using Definition;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
    private Camera mainCamera; // ���� ī�޶�
    private void Start()
    {
        mainCamera = Camera.main; // ���� ī�޶� ����
    }

    private void Update()
    {
        // ���콺 ���� ��ư�� Ŭ���Ǿ��� ��
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // ����ĳ��Ʈ�� ���� ��ü ����
            if (Physics.Raycast(ray, out hit))
            {
                // ������ ��ü�� �̸��� ����� �α׷� ���
                Debug.Log("Ŭ���� ��ü: " + hit.collider.gameObject.layer);
                SystemManager.Instance.istate.TypeClassification(hit.collider.gameObject);

                //hit.collider.gameObject.layer;
            }
        }
    }
}
