using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject mainCube;
    int height;
    // Start is called before the first frame update
    void Start()
    {
        mainCube = GameObject.Find("MainCube");
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height+0.5f, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);

        
    }
    public void decreaseHeight()
    {
        height--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect" && other.gameObject.GetComponent<CollectibleCube>().getIsCollect() == false)
        {
            height += 1;
            other.gameObject.GetComponent<CollectibleCube>().setCollect();
            other.gameObject.GetComponent<CollectibleCube>().setIndex(height);
            other.gameObject.transform.parent = mainCube.transform;


        }
    }
}
