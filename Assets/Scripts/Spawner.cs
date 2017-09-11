using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject enemy;

    public float minSpawn;
    public float maxSpawn;

    public float harderTime = 5f;
    public float hardestTime = 10f;

    float spawnTime = 1f;

    bool raiseDiff = false;
    bool raiseDiffMore = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnEnemy());
	}

    private IEnumerator SpawnEnemy()
    {
        GameObject _temp = Instantiate(enemy, transform.position, Quaternion.identity);
        _temp.transform.position += new Vector3(0f, Random.Range(minSpawn, maxSpawn));

        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update () {
        if (!raiseDiff && Time.time >= harderTime)
        {
            raiseDiff = true;
            spawnTime -= 0.2f;
        }

        if (!raiseDiffMore && Time.time >= hardestTime)
        {
            raiseDiff = true;
            spawnTime -= 0.3f;
        }
    }
}
