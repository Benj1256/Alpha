using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{ 

    private Vector3 startPos;
    private float repeatWidth;

    private GameObject image;
    public GameObject image2;
    public GameObject goal;
    private int count = 0;




    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("image1");
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
            count++;

            if (count == 5)
            {
                goal.gameObject.SetActive(true);
               

            }

            else if(count > 5)
            {
                image.gameObject.SetActive(false);
                image2.gameObject.SetActive(true);
                goal.gameObject.SetActive(false);
            }

            

        }

        //Goal keep moving by z vlaue fix when have time
        
    }
}
