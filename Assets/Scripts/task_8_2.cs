using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";

        int i = 0;
        while (i < 7)
        {

            int random = Random.Range(0, words.Length);
            sentence += words[random] + " ";
            i++;
        }
        Debug.Log(sentence);

    }
}
