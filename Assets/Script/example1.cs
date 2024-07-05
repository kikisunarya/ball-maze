using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example1 : MonoBehaviour
{
    [SerializeField]
    private GameObject _square;

    // Start is called before the first frame update
    void Start()
    {
        // Mengubah nama game object square menjadi kotak
_square.name = "Kotak";

    // Mendapatkan informasi nama dari game object square
Debug.Log(_square.name);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
