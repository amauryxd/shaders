using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class d202 : MonoBehaviour
{
    public Material material;
    public float x6, y6, x9, y9;
    // Start is called before the first frame update
    void Start()
    {
        //CreateCube();
    }
    private void Update()
    {
        CreateCube();
    }
    // Update is called once per frame
    void CreateCube()
    {
        Vector3[] vertices = {
         //Abajo
        new Vector3(0,0,0),//1
        new Vector3(0, 0, 0),//2
        new Vector3(0, 0, 0),//3
        new Vector3(0, 0, 0),//4
        new Vector3(0, 0, 0),//5
        //enmedioabajo
        new Vector3(-0.55f, 1.1f, -1.7f),//6
        new Vector3(1.55f, 1.1f, -1.05f),//7
        new Vector3(-1.8f, 1.1f, 0),//8
        new Vector3(-0.55f, 1.1f, -1.7f),//9
        new Vector3(1.55f, 1.1f, 1.05f),//10
        new Vector3(-0.55f, 1.1f, 1.7f),//11
        //enemdioarriba
        new Vector3(0.55f, 2.9f, -1.7f), //12
        new Vector3(-1.45f, 2.9f, -1.05f), //13
        new Vector3(1.8f, 2.9f, 0),//14
        new Vector3(-1.45f, 2.9f, -1.05f),//15
        new Vector3(-1.45f, 2.9f, 1.05f), //16
        new Vector3(0.55f, 2.9f, 1.7f), //17
        //arriba
        new Vector3(0, 4, 0),  //18
        new Vector3(0, 4, 0), //19
        new Vector3(0, 4, 0), //20
        new Vector3(0, 4, 0), //21
        new Vector3(0, 4, 0), //22



    };

        int[] triangles =
        {
            //abajo
            //0,1,2, //123
            //abajomedio mirandoabajo
            //3,4,2,//453
            //4,5,0,//561
            //5,6,0,//671
            //6,7,1,//782
            //7,8,1,//892
            //8,3,2,//943
            //abajomedio mirandoarriba
            //0,6,1,//172
            //1,8,2,//293
            //2,4,0,//351
            //arribamedio mirando arriba
            //5,11,6,//6,12,7
            //6,11,7,//7,12,8
            //7,9,8,//8,10,9
            //8,9,3,//9,10,4
            //3,10,4,//4,11,5
            //4,10,5,//5,11,6
            //arribamedio mirando abajo
            //5,10,11,//6,11,12
            //7,11,9,//8,12,10
            //3,9,10,//4,10,11
            //arriba
            //9,11,10//10,11,12
            //bottom


            0,5,6, //167
            1,6,9, //2710
            2,9,10, //31011
            3,10,7, //4118
            4,7,8, //589
            17,11,12,//181211
            18,13,11,//191412
            19,16,13,//201714
            20,15,16,//211617
            21,14,15,//221516
            12,11,5,//13126
            5,11,6,//6127
            11,13,6,//12147
            13,9,6,//14107
            13,16,9,//141710
            16,10,9,//171110
            15,10,16,//161117
            15,7,10,//16811
            15,14,7,//16158
            14,8,7,//1598





        };


        Vector2[] uvs = {

            new Vector2(0.556f,0f), //0
            new Vector2(0.667f,0.2f), //1
            new Vector2(0.778f,0.4f), //2
            new Vector2(0.889f,0.6f), //3
            new Vector2(1f,0.8f), //4
 
            new Vector2(0.333f,0f), //5
            new Vector2(0.444f,0.2f), //6
            new Vector2(0.778f,0.8f), //7
            new Vector2(0.889f,1f), //8
            new Vector2(0.556f,0.4f), //9
            new Vector2(0.667f,0.6f), //10
            
            new Vector2(0.222f,0.2f), //11
            new Vector2(0.111f,0f), //12
            new Vector2(0.333f,0.4f), //13
            new Vector2(0.667f,1f), //14
            new Vector2(0.556f,0.8f), //15
            new Vector2(0.444f,0.6f), //16
            
            new Vector2(0f,0.2f), //17
            new Vector2(0.111f,0.4f), //18
            new Vector2(0.222f,0.6f), //19
            new Vector2(0.333f,0.8f), //20
            new Vector2(0.444f,1f), //21

            /*
            new Vector2(0.445f,0.2f),//0
            new Vector2(0.225f,0.2f),//1
            new Vector2(0.66625f,0.6f),//2
            new Vector2(0.555f,0.8025f),//3
            new Vector2(0.445f,0.6f),//4
            new Vector2(0.33375f,0.4f),//5
            new Vector2(0.7775f,0.8025f),//6
            new Vector2(0.89f,1),//7
            new Vector2(0.105f,0),//8
            new Vector2(0.225f,0.6f),//9
            new Vector2(0.775f,0.4025f),//10
            new Vector2(0.55625f,0.4025f),//11
            */



        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
