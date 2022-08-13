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
        
        //�ڷ�ƾ �Լ��� ����� ��
        //��ȯ���� IEnumerator CountAttackDelay() , ����Ƽ������ �̷��� ����
        //yield return ->�ڷ�ƾ�� �����ϴٰ� ������ ������ ������� ����Ƽ�� �ٽ� ������(�ڷ�ƾ ���� ����)
        //null - 1������ ��ٸ�
        //WaitForSeconds() �������� �Ű������� ���� ���� ��ٸ�
        //WaitForSecondsRealtime(); TimeScale�� ������ �޴°� �ȹ޴°�(�ð��� ���̸� �����ϴ� ��.)
        //Time.timeScale = 0.5f; 0.5���
        //new WaitForSeconds(1); -> 0.5��
        //new WaitForSecondsRealtime(1); -> ���� 1��
        //new WaitForFixedUpdate(); -> �Ƚõ� ������Ʈ ������ ������ ������� ��������
        //new WaitForEndOfFrame(); �� �������� �������� ������ ������ ���� ���߿� ������� ��������.
 
    }

    IEnumerator CountAttackDelay()
    {
        yield return new WaitForSeconds(delayTime); //�Լ��� ������� ��ȯ�ϴ� �ڵ�
        isDelay = false;
    }
}
