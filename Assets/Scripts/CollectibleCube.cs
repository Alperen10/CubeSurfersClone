using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCube : MonoBehaviour
{
    bool isCollect;
    int index;
    public Collector collector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (isCollect == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            collector.decreaseHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool getIsCollect()
    {
        return isCollect;
    }

    public void setCollect()
    {
        isCollect = true;
    }
    public void setIndex(int index)
    {
        this.index = index;
    }
    
}
