using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ekle : MonoBehaviour
{
    Vector3 pos = new Vector3(0f,0f,0f);
    // Start is called before the first frame update
    public GameObject kapsul;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos.x = Random.Range(0f, 10f);
            pos.z = Random.Range(0f, 10f);
            pos.y = this.transform.position.y;
            this.transform.position = pos;
            Instantiate(kapsul, transform.position, transform.rotation);
        }
    }
}
