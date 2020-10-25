using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellySchool : MonoBehaviour
{

    public GameObject jellyPrefab;
    public List<GameObject> myjellyList;
    public int maxJelly = 100;

    // Start is called before the first frame update
    void Start()
    {
        int jellyCounter = 0;

        while(jellyCounter < maxJelly)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0);

            GameObject myNewJelly = Instantiate(jellyPrefab, spawnPos, Quaternion.Euler(0, 0, Random.Range(-180f, 180f)));

            //add jelly to list
            myjellyList.Add(myNewJelly);

            jellyCounter += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            for(int i = 0; i < myjellyList; i++)
            {

                myjellyList[i].GetComponent<jellyfishGen>().destination = Vector3.zero; 
            }
        }
    }
}
