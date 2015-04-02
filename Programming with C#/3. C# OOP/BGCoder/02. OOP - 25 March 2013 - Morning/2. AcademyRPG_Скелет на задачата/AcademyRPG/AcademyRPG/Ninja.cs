using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private int attacPoint;
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get { return this.attacPoint; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets
                .OrderByDescending(t => t.HitPoints)
                .FirstOrDefault(t => t.Owner != this.Owner && t.Owner != 0);

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.attacPoint += resource.Quantity * 2;
                return true;
            }
            else if (resource.Type == ResourceType.Lumber)
            {
                this.attacPoint += resource.Quantity;
                return true;
            }

            return false;
        }
    }
}
