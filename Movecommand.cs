using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecommand : Command
{
    Transform target;
    Vector2 translation;

    public Movecommand(Transform target, Vector2 translation)
    {
        this.target = target;
        this.translation = translation;
    }
    public override void Execute()
    {
        target.Translate(translation);
        CommandManager.Instance.PushCommadn(this);
    }
    public override void Undo()
    {
        target.Translate(-translation);
    }

}
