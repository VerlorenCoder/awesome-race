﻿using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshDeformer : MonoBehaviour {
    Mesh deformingMesh;
    Vector3[] originalVertices;
    float strength = 0.01f;
    private GameObject smoke;
    private GameObject smokeBack;
    private int crashes = 0;
    private bool isOnFire = false;

    public void Crash() {
        AddDeformingForce();
    }

    void Start() {
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVertices = deformingMesh.vertices;
        smoke = GameObject.Find("WhiteSmoke");
        smoke.GetComponent<ParticleSystem>().enableEmission = false;
        smokeBack = GameObject.Find("WhiteSmoke2");
        smokeBack.GetComponent<ParticleSystem>().enableEmission = false;
    }

    public void AddDeformingForce() {
        for (int i = 0; i < originalVertices.Length; i++) {
            AddForceToVertex(i);
        }

        crashes++;

        if(!isOnFire && crashes > 3) {
            smoke.GetComponent<ParticleSystem>().enableEmission = true;
            isOnFire = true;
        }

        if (isOnFire && crashes > 6)
        {
            smokeBack.GetComponent<ParticleSystem>().enableEmission = true;
        }
    }

    void AddForceToVertex(int i) {
        if(Random.Range(0, 30) == 0) {
            Vector3 random = new Vector3(Random.Range(0, strength), -Random.Range(0, strength), -Random.Range(0, strength));
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