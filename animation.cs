using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    private Animation ani; //애니메이션을 ani라는 변수로 제어한다. 

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent <Animation>();//유니티 엔진의 animation을 받아와서 ani에 넣어준다. 


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))//W키가 눌려지면 animation을 바꿔준다. 
        {
            //ani.Play("Cube_2"); //W키가 눌려지면 만들었던 Cube_2 animation을 재생해준다. 
            //ani.PlayQueued("Cube_2"); //Cube_1의 play가 끝나고 Cube_2가 play되도록 한다. 
            ani.Blend("Cube_2"); //Cube_1과 같이 재생하고 싶으면, Blend를 사용한다. 
            //ani.CrossFade("Cube_2"); //Cube_1이 실행되던 것이 자연스럽게 사라지고, Cube_2로 대체된다. 
            //ani.IsPlaying("Cube_2"); //Cube_2가 실행중이면 true가 반환됨. (조건문에서 조건으로 활용)

        }
        
    }
}
