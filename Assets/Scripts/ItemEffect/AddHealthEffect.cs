using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int addhealthamount = 10;
    public override bool Use(CharacterData user)
    {
        VFXManager.PlayVFX(VFXType.Healing, user.transform.position);
        user.Stats.ChangeHealth(addhealthamount);
        return true;
    }
}
