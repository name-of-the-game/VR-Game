using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat;
    private float timer;
    bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if( isActive )
        {
            isActive = false;
            //if (timer > beat)
            //{
                var postion = Random.Range(0, 4);
                var point = 0;

                if (postion == 0)
                {
                    point = Random.Range(0, 7);
                }
                else if (postion == 1)
                {
                    point = Random.Range(2, 9);
                }
                else if (postion == 2)
                {
                    point = Random.Range(4, 11);
                }
                else
                {
                    point = Random.Range(0, 11);
                }

                GameObject cube = Instantiate(cubes[postion], points[point]);
                cube.transform.localPosition = Vector3.zero;
                //timer -= beat;
            //}

            //timer += Time.deltaTime;
            StartCoroutine("DoCheck");
        }
        
    }

    IEnumerator DoCheck()
    {
        yield return new WaitForSeconds(2.0f);
        isActive = true;
    }
}
