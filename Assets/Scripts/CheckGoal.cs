using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckGoal : MonoBehaviour
{
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, goal.transform.position);
        if (distance < 0.21)
        {
            var rigidBody = GetComponent<Rigidbody>();
            rigidBody.useGravity = false;
            rigidBody.velocity = Vector3.zero;
            StartCoroutine(DelayCoroutine());
        }
    }

    private IEnumerator DelayCoroutine()
    {

        yield return new WaitForSeconds(2);

        // 3秒後に原点にメイン画面
        SceneManager.LoadScene("EndScene");

    }
}
