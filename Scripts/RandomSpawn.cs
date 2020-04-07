
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class RandomSpawn : UdonSharpBehaviour
{
    [SerializeField] GameObject spw;
    [SerializeField] Vector3 position;
    public override void Interact()
    {
        
        var mr = this.gameObject.GetComponent<MeshRenderer>();

        if(mr != null){

            mr.material.SetColor("_Color",Color.cyan);
        }

        float r = Random.Range(0f,10f);
        var s = VRCInstantiate(spw);
        
        var setp = position;
        setp.x += r;
        s.transform.localPosition = setp;
    }
}
