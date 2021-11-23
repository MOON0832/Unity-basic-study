using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private BoxCollider col;
    

    void Start() {

        col = GetComponent<BoxCollider>(); // boxcollider를 가져와서 col에 넣어준다. col변수로 큐브의 box colider를 통제할 수 있게 됨.

    }


    private void OnTriggerStay(Collider other)
    { //머물고 있으면 1초에 몇십번씩 계속 실행됨
        other.transform.position += new Vector3(0, 0, 0.1f); //머물고 있으면, 상대방의 position을 계속 더해줌. (계속 0.01씩 이동)
    }

    private void OnTriggerExit(Collider other)
    { //빠져나간 순간, position을 하늘로 올려본다. 
        other.transform.position += new Vector3(0, 2, 0); //머물고 있으면, 상대방의 position을 계속 더해줌. (계속 0.01씩 이동)
    }
}
