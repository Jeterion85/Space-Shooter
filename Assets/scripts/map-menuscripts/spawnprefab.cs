using UnityEngine;

public class spawnprefab : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    private float spawnInterval;
    public float spawnIntervalMin;
    public float spawnIntervalMax;

    public float maxspeed;
    public float minspeed;
    [HideInInspector] public float speed;


    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        //Instantiate(myPrefab, new Vector3(15, 0, 0), Quaternion.identity);
        spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
    }

    private void Update()
    {
        spawnInterval -= Time.deltaTime;
        if (spawnInterval <= 0)
        {
            speed = Random.Range(minspeed, maxspeed);
            Instantiate(myPrefab, new Vector3(transform.position.x, transform.position.y + random(), 0), transform.rotation);
            spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
        }
        
    }

    int random()
    {
        int X = Random.Range(-5,5);        
        return X;
    }
}