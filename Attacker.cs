using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public bool isDelay;
    public float delayTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isDelay)
            {
                isDelay = true;
                Debug.Log("Attack");
                StartCoroutine(CountAttackDelay());
            }
            else
            {
                Debug.Log("Delay");
            }

        }
        
        //코루틴 함수를 만드는 법
        //반환형만 IEnumerator CountAttackDelay() , 유니티에서는 이렇게 만듬
        //yield return ->코루틴이 동작하다가 리턴을 만나면 제어권을 유니티에 다시 돌려줌(코루틴 동작 종료)
        //null - 1프레임 기다림
        //WaitForSeconds() 생성자의 매개변수로 넣은 값만 기다림
        //WaitForSecondsRealtime(); TimeScale의 영향을 받는가 안받는가(시간의 길이를 조절하는 것.)
        //Time.timeScale = 0.5f; 0.5배속
        //new WaitForSeconds(1); -> 0.5초
        //new WaitForSecondsRealtime(1); -> 실제 1초
        //new WaitForFixedUpdate(); -> 픽시드 업데이트 과정이 끝나면 제어권을 돌려받음
        //new WaitForEndOfFrame(); 한 프레임이 지나가는 과정이 끝나면 가장 나중에 제어권을 돌려받음.
 
    }

    IEnumerator CountAttackDelay()
    {
        yield return new WaitForSeconds(delayTime); //함수의 결과값을 반환하는 코드
        isDelay = false;
    }
}
