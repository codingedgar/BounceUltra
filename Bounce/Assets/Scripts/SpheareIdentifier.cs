using UnityEngine;
using System;
public enum SpheareType
{
    Blue,
    Red,
    Green,
    Yellow,
}

public static class SpheareTypeExtentions
{
    public static Sprite ToSprite(this SpheareType type)
    {
        Sprite returner = null;
        returner = Resources.Load<Sprite>("Sprites/Sprite" + type.ToString());
        return returner;
    }

    public static Material ToMaterial (this SpheareType type)
    {
        Material returner = null;

        returner = Resources.Load<Material>("Materials/Ball" + type.ToString());

        return returner;
    }
    

}

public class SpheareIdentifier : MonoBehaviour
{
    public SpheareType type = SpheareType.Red;
    SphereSetUp setup;

    public void InitWithRandom(SphereSetUp setup)
    {
        this.setup = setup;
        RamdomType();
        SetMaterials();
    }

    public void RamdomType()
    {
        int r = UnityEngine.Random.Range(0, Enum.GetValues(typeof(SpheareType)).Length);

        type = (SpheareType)r;
        
    }

    public void SetMaterials()
    {
        setup.renderer.material = this.type.ToMaterial();
    }
}
