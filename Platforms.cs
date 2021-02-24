using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject iceCreamPrefab;
    public GameObject enemyPrefab;
    float startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position.x;

        for (int i = 0; i < 5; i++)
        {
            print("Platform!");
            GameObject newPlatform = Instantiate(platformPrefab);  
            float rand = Random.Range(0f, 2f);
            startPos = startPos + 8;
            newPlatform.transform.position = new Vector3(startPos-rand,newPlatform.transform.position.y+rand,newPlatform.transform.position.z);
            int iceCreamCheck = Random.Range(0, 10);
            if (iceCreamCheck >= 5)
            {
                GameObject newIceCream = Instantiate(iceCreamPrefab);
                newIceCream.transform.position = new Vector3(newPlatform.transform.position.x, newPlatform.transform.position.y + 1f, newPlatform.transform.position.z);
            }  
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= startPos - 10)
        {
           print("Platform!");
            GameObject newPlatform = Instantiate(platformPrefab);  
            float rand = Random.Range(0f, 2f);
            startPos = startPos + 8;
            newPlatform.transform.position = new Vector3(startPos-rand,newPlatform.transform.position.y+rand,newPlatform.transform.position.z);
            int iceCreamCheck = Random.Range(0, 10);
            if (iceCreamCheck >= 4)
            {
                GameObject newIceCream = Instantiate(iceCreamPrefab);
                newIceCream.transform.position = new Vector3(newPlatform.transform.position.x, newPlatform.transform.position.y + 1f, newPlatform.transform.position.z);
            }  
            else if (iceCreamCheck <= 3)
            {
                GameObject newEnemy = Instantiate(enemyPrefab);
                newEnemy.transform.position = new Vector3(newPlatform.transform.position.x, newPlatform.transform.position.y + 1f, newPlatform.transform.position.z);
            }
        }
    }
}
