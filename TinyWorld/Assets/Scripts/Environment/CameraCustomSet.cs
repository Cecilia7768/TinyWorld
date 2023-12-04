using UnityEngine;

public class CameraCustomSet : MonoBehaviour
{
    //public Transform target; // ī�޶� ����ٴ� ��� (ĳ����)
    public float smoothSpeed = 0.125f; // ī�޶� �̵� ������ ����

    //private Vector3 offset;

    //void Start()
    //{
    //    offset = transform.position - target.position; // ī�޶�� ����� �ʱ� �Ÿ� ����
    //}

    //void LateUpdate()
    //{
    //    Vector3 desiredPosition = target.position + offset; // ����� ��ġ�� �Ÿ� ���̸� ���Ͽ� ��ǥ ��ġ ���
    //    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // �ε巯�� �̵� ���

    //    transform.position = smoothedPosition; // ī�޶� ��ġ ������Ʈ
    //}
    public Transform target;
    public float distance = 10.0f; // �ʱ� ī�޶�� ��� ������ �Ÿ�
    public float zoomSpeed = 2.0f; // �� �ӵ�
    public float minZoom = 5.0f; // �ּ� �� �Ÿ�
    public float maxZoom = 15.0f; // �ִ� �� �Ÿ�



    private Vector3 offset;
    private float noWheelInputTime = 0f;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        // ���콺 �� �Է��� �޾� FOV ����
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            noWheelInputTime = 0f;
            distance -= scroll * zoomSpeed;
            distance = Mathf.Clamp(distance, minZoom, maxZoom);
        }
        else
        {
            noWheelInputTime += Time.deltaTime;
            if (noWheelInputTime >= 2f) // 2�� �̻� �� �Է��� ������ �ʱ�ȭ
            {
                distance = 10.0f; // �� ���� ���� ī�޶� �Ÿ��� ����
            }
        }

        //// ī�޶� ��ġ ������Ʈ
        //Vector3 targetPosition = target.position + offset.normalized * distance;
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);

        //// ī�޶� ��� �ٶ󺸵��� ȸ��
        //transform.LookAt(target.position);
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // ����� ��ġ�� �Ÿ� ���̸� ���Ͽ� ��ǥ ��ġ ���
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // �ε巯�� �̵� ���

        transform.position = smoothedPosition; // ī�޶� ��ġ ������Ʈ
    }
}
