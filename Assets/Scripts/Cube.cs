using UnityEngine;

public class Cube 
{

    GameObject cube;
    Color[] cos = { Color.red, Color.grey, Color.blue, Color.yellow, Color.green, Color.cyan };

    public Cube()
    {

        cube = new GameObject("Cube");
        cube.transform.position = new Vector3(0, 3, 0);
        var filter = cube.AddComponent<MeshFilter>();
        var rend = cube.AddComponent<MeshRenderer>();


        Vector3[] vertices = new Vector3[24];
        Color[] colors = new Color[24];
        int[] triangles = new int[36];

        //forward
        vertices[0].Set(0.5f, -0.5f, 0.5f);
        vertices[1].Set(-0.5f, -0.5f, 0.5f);
        vertices[2].Set(0.5f, 0.5f, 0.5f);
        vertices[3].Set(-0.5f, 0.5f, 0.5f);
        //back
        vertices[4].Set(vertices[2].x, vertices[2].y, -0.5f);
        vertices[5].Set(vertices[3].x, vertices[3].y, -0.5f);
        vertices[6].Set(vertices[0].x, vertices[0].y, -0.5f);
        vertices[7].Set(vertices[1].x, vertices[1].y, -0.5f);
        //up
        vertices[8] = vertices[2];
        vertices[9] = vertices[3];
        vertices[10] = vertices[4];
        vertices[11] = vertices[5];
        //down
        vertices[12].Set(vertices[10].x, -0.5f, vertices[10].z);
        vertices[13].Set(vertices[11].x, -0.5f, vertices[11].z);
        vertices[14].Set(vertices[8].x, -0.5f, vertices[8].z);
        vertices[15].Set(vertices[9].x, -0.5f, vertices[9].z);
        //right
        vertices[16] = vertices[6];
        vertices[17] = vertices[0];
        vertices[18] = vertices[4];
        vertices[19] = vertices[2];
        //left
        vertices[20].Set(-0.5f, vertices[18].y, vertices[18].z);
        vertices[21].Set(-0.5f, vertices[19].y, vertices[19].z);
        vertices[22].Set(-0.5f, vertices[16].y, vertices[16].z);
        vertices[23].Set(-0.5f, vertices[17].y, vertices[17].z);
        
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                colors[i * 4 + j] = cos[i];
            }
        }

        int currentCount = 0;
        for (int i = 0; i < 24; i = i + 4)
        {
            triangles[currentCount++] = i;
            triangles[currentCount++] = i + 3;
            triangles[currentCount++] = i + 1;

            triangles[currentCount++] = i;
            triangles[currentCount++] = i + 2;
            triangles[currentCount++] = i + 3;
        }

        filter.mesh.vertices = vertices;
        filter.mesh.triangles = triangles;
        filter.mesh.colors = colors;
        rend.material = Resources.Load<Material>("Vertx");
    }


    private void Update()
    {
        if (cube != null)
        {
            cube.transform.Rotate(0.3f, 0.2f, 0.2f);
        }
    }

}