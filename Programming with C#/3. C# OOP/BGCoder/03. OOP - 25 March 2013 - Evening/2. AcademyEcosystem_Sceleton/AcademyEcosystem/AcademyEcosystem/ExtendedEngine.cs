using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class ExtendedEngine : Engine
    {
        private const string WolfType = "wolf";
        private const string LionType = "lion";
        private const string GrassType = "grass";
        private const string BoarType = "boar";
        private const string ZombieType = "zombie";



        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            string organizamType = commandWords[1];

            switch (organizamType)
            {
                case "deer":
                case "tree":
                case "bush":
                    {
                        base.ExecuteBirthCommand(commandWords);
                        return;
                    }
                case WolfType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        Wolf newWolf = new Wolf(name, position);
                        this.AddOrganism(newWolf);
                        break;
                    }
                case LionType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        Lion newLion = new Lion(name, position);
                        this.AddOrganism(newLion);
                        break;
                    }
                case GrassType:
                    {
                        Point position = Point.Parse(commandWords[2]);
                        Grass newGrass = new Grass(position);
                        this.AddOrganism(newGrass);
                        break;
                    }
                case BoarType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        Boar newBoar = new Boar(name, position);
                        this.AddOrganism(newBoar);
                        break;
                    }
                case ZombieType:
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        Zombie newZombie = new Zombie(name, position);
                        this.AddOrganism(newZombie);
                        break;
                    }
            }
        }
    }
}
