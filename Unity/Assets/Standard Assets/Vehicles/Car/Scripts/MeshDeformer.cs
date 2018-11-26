using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshDeformer : MonoBehaviour {
    Mesh deformingMesh;
    Vector3[] originalVertices;

    void Start() {
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
    }

    public void AddDeformingForce(Vector3 point) {
        for (int i = 0; i < originalVertices.Length; i++) {
            AddForceToVertex(i, point);
        }
    }

    void AddForceToVertex(int i, Vector3 point) {
        if(Random.Range(0, 30) == 0) {
            Vector3 random = new Vector3(Random.Range(0, 0.003f), Random.Range(0, 0.001f), Random.Range(0, 0.003f));
            originalVertices[i] = originalVertices[i] + random;
        }
    }

    void Update() {
        deformingMesh.vertices = originalVertices;
        deformingMesh.RecalculateNormals();
    }
}