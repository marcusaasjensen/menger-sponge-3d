using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MengerSponge : MonoBehaviour
{
    public int size = (int) Mathf.Pow(3,1);
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public GameObject pointPrefab;
    void Start()
    {
        GenerateMengerSponge(size, x, y, z);
    }

    public void GenerateMengerSponge(int size, int x, int y, int z)
    {
        if(size > 1f)
        {
            size /= 3;

            //front side
            GenerateMengerSponge(size, x, y, z);
            GenerateMengerSponge(size, x+size, y, z);
            GenerateMengerSponge(size, x+2*size, y, z);
            GenerateMengerSponge(size, x+2*size, y+size, z);
            GenerateMengerSponge(size, x, y+size, z);
            GenerateMengerSponge(size, x, y+2*size, z);
            GenerateMengerSponge(size, x+size, y+2*size, z);
            GenerateMengerSponge(size, x+2*size, y+2*size, z);
            
            //Z edges
            GenerateMengerSponge(size, x, y, z+size);
            GenerateMengerSponge(size, x+2*size, y, z+size);
            GenerateMengerSponge(size, x, y+2*size, z+size);
            GenerateMengerSponge(size, x+2*size, y+2*size, z+size);

            //back side
            GenerateMengerSponge(size, x, y, z+2*size);
            GenerateMengerSponge(size, x+size, y, z+2*size);
            GenerateMengerSponge(size, x+2*size, y, z+2*size);
            GenerateMengerSponge(size, x+2*size, y+size, z+2*size);
            GenerateMengerSponge(size, x, y+size, z+2*size);
            GenerateMengerSponge(size, x, y+2*size, z+2*size);
            GenerateMengerSponge(size, x+size, y+2*size, z+2*size);
            GenerateMengerSponge(size, x+2*size, y+2*size, z+2*size);
            
        } else
        {
            GameObject p = Instantiate(pointPrefab, new Vector3(x, y, z), Quaternion.identity, transform.parent);
            p.transform.parent = transform;
        }
    }
}
