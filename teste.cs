using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pessoas
{
    public string nome;
    public int idade;
}
public class teste : MonoBehaviour
{

    public Pessoas[] peoples;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < peoples.Length; i++)
        {
            Debug.Log(peoples[i].nome);
            Debug.Log(peoples[i].idade);

            //Mesma coisa que "print" ;-;
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
}
