using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class Treasures_Effect : EquipmentItem.EquippedEffect
{
    public int strengthBonus = 5;
     public override void Equipped(CharacterData user)
     {
        VFXManager.PlayVFX(VFXType.Stronger, user.transform.position);
        user.Stats.stats.strength += strengthBonus;

     }
     
     public override void Removed(CharacterData user)
     {
        VFXManager.PlayVFX(VFXType.Negative, user.transform.position);
        user.Stats.stats.strength -= strengthBonus;
     }
}
