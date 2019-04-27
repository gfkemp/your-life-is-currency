using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject person;
    public float radius = 100f;
    public int total = 100;

    public Sprite[] sprites;

    private void Start()
    {
        for (int i = 0; i < total; i++)
        {
            Vector3 loc = Random.insideUnitSphere * radius;
            loc.y = 0.3f;
            GameObject p = Instantiate(person, loc, Quaternion.identity);
            p.transform.parent = this.transform;

            Person per = p.GetComponent<Person>();
            per.SetSprite(sprites[Random.Range(0, sprites.Length)]);
        }
    }
}
