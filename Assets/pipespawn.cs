using System.Threading;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightrate = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else {
            spawn();
            timer = 0;
        }
        
        
    }
    void spawn()
    {
        float lowestpoint = transform.position.y - heightrate;
        float highestpoint= transform.position.y + heightrate;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
