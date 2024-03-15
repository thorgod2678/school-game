using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Sprite[] dry;
   public Sprite[] wet;
    public Sprite[] elec;
    
    
    public GameObject[] objectsToSpawn;
    public Transform[] spawnPoint;
    public float spawnInterval = 1f;
    public Transform spawnPoints;

    private float timer;

    void Update()
    {

        
        int x = Random.Range(0,spawnPoint.Length);
        spawnPoints = spawnPoint[x];
        
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Sprite();
            //Sprite2();
            SpawnObject();
            timer = spawnInterval;
        }
    }

    void SpawnObject()
    {
        int randomIndex = Random.Range(0, objectsToSpawn.Length);
        GameObject spawnedObject = Instantiate(objectsToSpawn[randomIndex], spawnPoints.position, Quaternion.identity);
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            //rb.AddForce(Vector3.down * 10f, ForceMode.Impulse); // Adjust the force as needed
        }
       // Destroy(spawnedObject, 5f); // Destroy the object after 5 seconds (adjust as needed)
    }


    private void Sprite()
    {
        GameObject x = objectsToSpawn[0];//dry waste
        GameObject y = objectsToSpawn[1];//wet waste
        GameObject z = objectsToSpawn[2];//electronic waste

        Sprite a = dry[Random.Range(0,dry.Length)];//dry sprite
        Sprite b = wet[Random.Range(0, wet.Length)];//wet sprite
        Sprite c = elec[Random.Range(0, elec.Length)];//electronic sprite

        x.GetComponent<SpriteRenderer>().sprite = a;
        y.GetComponent<SpriteRenderer>().sprite = b;
        z.GetComponent<SpriteRenderer>().sprite = c;

        objectsToSpawn[0] = x;
        objectsToSpawn[1] = y;
        objectsToSpawn[2] = z;

    }

    private void Sprite2()
    {
        GameObject a = objectsToSpawn[0];//dry waste
        GameObject b = objectsToSpawn[1];//wet waste
        GameObject c = objectsToSpawn[2];//electronic waste


        int x = Random.Range(0, 255);
        int y = Random.Range(0, 255);
        int z = Random.Range(0, 255);
        
        Color color = new Color(x,y, z, 255);

        a.GetComponent<SpriteRenderer>().color = color;
        b.GetComponent<SpriteRenderer>().color = color;
        c.GetComponent<SpriteRenderer>().color = color;

        objectsToSpawn[0] = a;
        objectsToSpawn[1] = b;
        objectsToSpawn[2] = c;

        Debug.Log(x+" "+y+" "+z+" ");
    }
}
