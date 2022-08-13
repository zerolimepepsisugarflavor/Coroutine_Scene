using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene() // �񵿱� ��� �� �ε� , �ڷ�ƾ �̿�
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        yield return null;
    }
}
