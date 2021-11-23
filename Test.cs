using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] //직접 inspector 창에서 넣을 수 있도록
    private Material red_Mat;
    [SerializeField]
    private Material green_Mat;

    private MeshRenderer mesh;
    

    void Start() {

        mesh = GetComponent<MeshRenderer>();

    }


    void Update()
    {
        if (Input.GetMouseButton(0)) //마우스 좌클릭을 하고 있으면
        {
            mesh.material = green_Mat; //초록색으로 바꿔주고
        }
        else //좌클릭을 하고 있지 않으면 
        {
            mesh.material = red_Mat; //빨간색으로 바꿔준다.
        }

    }
}
