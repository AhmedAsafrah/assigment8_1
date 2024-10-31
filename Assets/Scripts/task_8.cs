using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int reandomNumber = Random.Range(1, 20);

            if (reandomNumber == 5)
            {
                continue;
            }
            else if (reandomNumber == 15)
            {
                break;
            }
            else
            {
                Debug.Log(reandomNumber);
            }
        }

    }


}
