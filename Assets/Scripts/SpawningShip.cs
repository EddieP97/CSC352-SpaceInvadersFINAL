using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningShip : MonoBehaviour
{
    public Transform enemies;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    IEnumerator enemyTimer()
    {
        yield return new WaitForSeconds(3);
        Instantiate(enemies, transform.position, transform.rotation);
        StartCoroutine(enemyTimer());
    }
}
