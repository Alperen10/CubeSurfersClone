using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float horizontalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * horizontalSpeed*Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, moveSpeed * Time.deltaTime);

        
    }
}
