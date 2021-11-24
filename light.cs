using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour

{
    private Light thelight;

    //currentIntensity값(현재의 Intensity)을 targerIntensity값에 강제로 맞춰주도록. 변수 2개 설정
    private float targetIntensity;
    private float currentIntensity;


    // Start is called before the first frame update
    void Start()
    {
        thelight = GetComponent<Light>(); //light component를 받아온다. 
        currentIntensity = thelight.intensity; // 현재 intensity값을 넣어준다. 
        targetIntensity = Random.Range(0.4f, 1f); //0.4~1.0 사이의 값을 랜덤하게 넣어준다.


    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(targetIntensity - currentIntensity) >= 0.01) //이경우 계속 반복 (두 값이 다른 경우)
        {
            if(targetIntensity-currentIntensity >= 0)
            {
                currentIntensity += Time.deltaTime * 3f; //증가
            }
            else
            {
                currentIntensity -= Time.deltaTime * 3f; //감소
            }

            thelight.intensity = currentIntensity; //실시간으로 intensity값을 반영해줌
            thelight.range = currentIntensity + 10; //10 언저리 범위에서 왔다갔다하도록
        }
        else
        {
            targetIntensity = Random.Range(0.4f, 1f);
        }
    }
}
