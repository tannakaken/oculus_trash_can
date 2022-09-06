using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    public Text text;
    private void Start()
    {
        // コルーチンの起動
        StartCoroutine(DelayCoroutine());
    }

    // コルーチン本体
    private IEnumerator DelayCoroutine()
    {

        yield return new WaitForSeconds(3);

        // 3秒後に原点にメイン画面
        SceneManager.LoadScene("MainScene");
        
    }

    /// <summary>
    /// タイトルを横に回転させる。
    /// </summary>
    private void Update()
    {
        text.transform.Rotate(0f, 120.0f * Time.deltaTime, 0f);
    }
}
