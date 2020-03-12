using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject bullet;
    public int pooledAmount = 20;
    private int indexToSave = 0;
    [SerializeField] private List<GameObject> bullets;
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        for(int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Instantiate(bullet) as GameObject;
            obj.SetActive(false);
            bullets.Add(obj);
        }
        InvokeRepeating("Fire", 2f, .5f);
    }

    void Fire()
    {



        if(!bullets[0].activeInHierarchy || !bullets[bullets.Count - 1].activeInHierarchy)
        {
            foreach(GameObject bullet in bullets)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
            }
        }
        else
        {
            bullets[indexToSave].SetActive(false);
            if(indexToSave == bullets.Count - 1)
            {
                indexToSave = 0;
            }
            else
            {
                indexToSave++;
            }
        }
        /*
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = transform.position;
                bullets[i].transform.rotation = transform.rotation;
                bullets[i].SetActive(true);
                break;
            }
            if (bullets[i].activeInHierarchy)
            {
                bullets[i].SetActive(false);
            }
           
        }
        */
    }
}
