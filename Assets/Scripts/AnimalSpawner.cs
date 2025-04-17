using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AnimalSpawner : MonoBehaviour
{
    public AssetReference Dog;
    private void Start()
    {
       
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnGameobject();
        }
    }
    private void SpawnGameobject()
    {
        var handle = Addressables.InstantiateAsync(Dog);
        handle.Completed += (AsyncOperationHandle<GameObject> task) =>
        {
            Instantiate(task.Result);
        };
    }
}
