using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//특정 대상을 따라다니는 카메라 구현
public class Test : MonoBehaviour
{
    [SerializeField] //직접 inspector 창에서 수정할 수 있도록
    private GameObject go_Target; //카메라가 따라갈 대상

    [SerializeField]
    private float speed; //얼만큼 빠른 speed로 따라갈지

    private Vector3 difValue; //카메라와 큐브의 거리를 유지하면서 따라갈 수 있도록 하는 변수


    void Start()
    {

        difValue = transform.position - go_Target.transform.position; //자기자신의 위치에서 target의 위치를 빼준다. 
        difValue = new Vector3(Mathf.Abs(difValue.x), Mathf.Abs(difValue.y), Mathf.Abs(difValue.z)); //difValue의 값이 항상 양수가 되도록 해준다. 
    }


    void Update()
    {
        //나온 계산값을 실제 움직임에 반영시켜준다. 그냥 위치값을 수정하지 않고 Lerp를 사용하여 부드럽게 움직이게 해준다. 
        //Lerp(좌표1, 좌표2, 비율) // 중간중간 비율에 따라 값을 도출해서 부드럽게 움직이도록 
        this.transform.position = Vector3.Lerp(this.transform.position, go_Target.transform.position + difValue, speed);

    }
}
