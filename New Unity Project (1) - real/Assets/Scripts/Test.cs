using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private BoxCollider col;
    

    void Start() {

        col = GetComponent<BoxCollider>(); // boxcollider를 가져와서 col에 넣어준다. col변수로 큐브의 box colider를 통제할 수 있게 됨.

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { //0=마우스 좌버튼, 1=마우스 우버튼
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // main camera라고 tag된 camera를 가져와서, 특정 좌표에 레이저를 쏘도록 함(여기서는 마우스좌표)
            RaycastHit hitinfo;  // 실제로 맞았는지 안맞았는지를 저장

            if (col.Raycast(ray, out hitinfo, 1000)){ //맞았으면 true가 되고, 안맞았으면 false가 된다.
                this.transform.position = hitinfo.point; //맞았으면,객체의 position값을 레이저를 쏜 곳으로 움직이게 해볼 것
            }
        }
    }
}
