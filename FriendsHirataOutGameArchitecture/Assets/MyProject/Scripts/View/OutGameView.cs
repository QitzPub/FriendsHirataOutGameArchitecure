using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Qitz.ArchitectureCore;

namespace Qitz.OuteGame
{
    public abstract class OutGameView : AView
    {
        protected OutGameController outGameController => this.GetController<OutGameController>();
    }
}
