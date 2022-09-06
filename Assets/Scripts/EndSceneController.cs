using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // コルーチンの起動
        StartCoroutine(DelayCoroutine());
    }

    // コルーチン本体
    private IEnumerator DelayCoroutine()
    {

        yield return new WaitForSeconds(3);

        // ３秒後にアプリを終了
        Application.Quit();

    }
}
