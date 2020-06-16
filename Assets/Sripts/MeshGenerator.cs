using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[4];

        vertices[0] = new Vector3(1.231f, 1.231f, 0);
        vertices[1] = new Vector3(1.231f, 2.472f, 0);
        vertices[2] = new Vector3(0.741f, 2.222f, 0);
        vertices[3] = new Vector3(1.852f, 1.852f, 0);

        mesh.vertices = vertices;

        mesh.triangles = new int[] { 0, 1, 2, 0, 1, 3 };

        GetComponent<MeshRenderer>().material = mat;

        GetComponent<MeshFilter>().mesh = mesh;
    }

  
}
