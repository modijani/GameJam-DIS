using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class abstractEndLevel : MonoBehaviour
{
    // Start is called before the first frame update
    protected string sceneName;

    protected abstract void Start();

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void OnCollisionEnter2D(Collision2D col2d)
    {
        if (col2d.collider.tag == "Player")
        {
            SceneManager.LoadScene(sceneName);
        }

    }
}
