using UnityEngine;

public class CameraCustomSet : MonoBehaviour
{
    //public Transform target; // 카메라가 따라다닐 대상 (캐릭터)
    public float smoothSpeed = 0.125f; // 카메라 이동 스무딩 정도

    //private Vector3 offset;

    //void Start()
    //{
    //    offset = transform.position - target.position; // 카메라와 대상의 초기 거리 차이
    //}

    //void LateUpdate()
    //{
    //    Vector3 desiredPosition = target.position + offset; // 대상의 위치에 거리 차이를 더하여 목표 위치 계산
    //    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // 부드러운 이동 계산

    //    transform.position = smoothedPosition; // 카메라 위치 업데이트
    //}
    public Transform target;
    public float distance = 10.0f; // 초기 카메라와 대상 사이의 거리
    public float zoomSpeed = 2.0f; // 줌 속도
    public float minZoom = 5.0f; // 최소 줌 거리
    public float maxZoom = 15.0f; // 최대 줌 거리



    private Vector3 offset;
    private float noWheelInputTime = 0f;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        // 마우스 휠 입력을 받아 FOV 조절
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
            if (noWheelInputTime >= 2f) // 2초 이상 휠 입력이 없으면 초기화
            {
                distance = 10.0f; // 이 값을 원래 카메라 거리로 변경
            }
        }

        //// 카메라 위치 업데이트
        //Vector3 targetPosition = target.position + offset.normalized * distance;
        //transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);

        //// 카메라가 대상 바라보도록 회전
        //transform.LookAt(target.position);
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // 대상의 위치에 거리 차이를 더하여 목표 위치 계산
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // 부드러운 이동 계산

        transform.position = smoothedPosition; // 카메라 위치 업데이트
    }
}
