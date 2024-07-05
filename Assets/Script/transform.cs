using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    [SerializeField]
private Transform _squareTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Cara lain merotasi transform object
_squareTransform.Rotate(0, 0, 1);

Debug.Log(_squareTransform.position);
    }
}
