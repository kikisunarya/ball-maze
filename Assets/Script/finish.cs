using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
{
    // Kode akan dijalankan ketika ada object lain masuk ke dalam trigger
    Debug.Log("Trigger Enter");
    SceneManager.LoadScene("game_over");
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
