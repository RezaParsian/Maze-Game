using System.Collections.Generic;
using UnityEngine;

public class Game_Maker : MonoBehaviour
{
    public string[] jobs;
    public GameObject player, object1, object2, object3;
    public List<Vector3> place;
    Vector3[] newplace = new Vector3[3];

    // Start is called before the first frame update
    void Start()
    {
        for (int t = 0; t < 3; t++)
        {
            int ind = Random.Range(0, place.Count);
            newplace[t] = place[ind];
            place.RemoveAt(ind);
        }

        int count = jobs.Length;
        int index = Random.Range(0, count);
        string job = jobs[index];

        string o1 = jobs[Random.Range(0, count)];
        string o2 = jobs[Random.Range(0, count)];

        while (o1 == job || o2 == job)
        {
            o1 = jobs[Random.Range(0, count)];
            o2 = jobs[Random.Range(0, count)];
        }

        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(job);
        object1.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(job + Random.Range(1, 3));
        object1.transform.position = newplace[0];
        object2.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(o1 + Random.Range(1, 3));
        object2.transform.position = newplace[1];
        object3.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(o2 + Random.Range(1, 3));
        object3.transform.position = newplace[2];
    }
}
