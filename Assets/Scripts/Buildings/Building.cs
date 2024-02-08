using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : Structures
{
    [SerializeField] private Transform spawnPoint;
    public Transform SpawnPoint { get { return spawnPoint; } }
    [SerializeField] private Transform rallyPoint;
    public Transform RallyPoint { get { return rallyPoint; } }

    [SerializeField] private GameObject[] unitPrefabs;

    [SerializeField] private List<Unit> recruitList = new List<Unit>();

    [SerializeField] private float unitTimer = 0f;
    [SerializeField] private int curUnitProgress = 0;

    [SerializeField] private float curUnitWaitTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        curHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
