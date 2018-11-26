using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshDeformer : MonoBehaviour {
    Mesh deformingMesh;
    Vector3[] originalVertices;
    float strength = 0.01f;

    public void Crash() {
        AddDeformingForce();
    }

    void Start() {
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
    }

    public void AddDeformingForce() {
        Debug.Log("Bum!");
        for (int i = 0; i < originalVertices.Length; i++) {
            AddForceToVertex(i);
        }
    }

    void AddForceToVertex(int i) {
        if(Random.Range(0, 30) == 0) {
            Vector3 random = new Vector3(Random.Range(0, strength), Random.Range(0, strength), Random.Range(0, strength));
            originalVertices[i] = originalVertices[i] + random;
        }
    }

    void Update() {
        deformingMesh.vertices = originalVertices;
        deformingMesh.RecalculateNormals();
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Bum!");
    }
}