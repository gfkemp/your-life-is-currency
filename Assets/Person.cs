using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour {

    private Sprite s;
    public Transform cam;
    public Vector3 rotation;
    public GameObject pizza;

    public void SetSprite(Sprite sp)
    {
        s = sp;
        this.GetComponent<SpriteRenderer>().sprite = s;
        this.transform.rotation = Quaternion.Euler(rotation);
    }

    public void Update()
    {
        //this.transform.LookAt(cam);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other is BoxCollider) { 
            Destroy(Instantiate(pizza, this.transform.position, Quaternion.identity), 3.5f);
        }
        Destroy(this.gameObject, 0.1f);
    }

}
