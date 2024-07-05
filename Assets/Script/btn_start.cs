using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class btn_start : MonoBehaviour
{
    public void ClickStart()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("gameplay");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
