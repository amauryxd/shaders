using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class d20 : MonoBehaviour
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
            //primer triangulo
            new Vector3(0,0,0),     //0
            new Vector3(1,0,0),     //1
            new Vector3(0.5f,0,1),  //2

            //hexagono
            new Vector3(0.5f,1,1.5f),//3
            new Vector3(-0.5f,1,1),//4
            new Vector3(-0.5f,1,-0.5f),//5
            new Vector3(0.5f,1,-1),//6
            new Vector3(1.5f,1,-0.5f),//7
            new Vector3(1.5f,1,1),//8

            //segundo triengulo
            new Vector3(1,2,0.5f),//9
            new Vector3(0,2,0.5f),//10
            new Vector3(0.5f,2,-0.5f),//11


        };

        int[] triangles =
        {
            //abajo
            0,1,2, //123
            //abajomedio mirandoabajo
            3,4,2,//453
            4,5,0,//561
            5,6,0,//671
            6,7,1,//782
            7,8,1,//892
            8,3,2,//943
            //abajomedio mirandoarriba
            0,6,1,//172
            1,8,2,//293
            2,4,0,//351
            //arribamedio mirando arriba
            5,11,6,//6,12,7
            6,11,7,//7,12,8
            7,9,8,//8,10,9
            8,9,3,//9,10,4
            3,10,4,//4,11,5
            4,10,5,//5,11,6
            //arribamedio mirando abajo
            5,10,11,//6,11,12
            7,11,9,//8,12,10
            3,9,10,//4,10,11
            //arriba
            9,11,10//10,11,12
        };
        Vector2[] uvs = {
            new Vector4(0.33398435f,0.051587125f,0.80706171875f,0.8701171875f),//new Vector2(0.33398435f,0.051587125f),//1
            new Vector4(0.1455078125f,0.051587125f,0.6181640625f,0.8701171875f),//new Vector2(0.1455078125f,0.051587125f),//2
            new Vector2(0.2392578125f,0.21484375f),//3
            new Vector2(0.33398435f,0.37890625f),//4
            new Vector2(0.4296815f,0.21484375f),//5
            new Vector2(x6,y6),//new Vector2(0.712890625f,0.37890625f),//6
            new Vector2(0.712890625f,0.7060546875f),//7
            new Vector2(0.5244140625f,0.7060546875f),//8
            new Vector2(x9,y9),//new Vector2(0.2392578125f,0.5419921875f),//9
            new Vector2(0.42773435f,0.5419921875f),//10
            new Vector2(0.5244140625f,0.37890625f),//11
            new Vector2(0.6181640625f,0.5419921875f),//12



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
