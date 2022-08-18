using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sekamar.SpaceShooter.Module.Player { 
    public class PlayerModel : BaseModel
    {
        public int hp { get; private set; }

        public void setHp(int i)
        {
            hp = i;
        }
    }
}
