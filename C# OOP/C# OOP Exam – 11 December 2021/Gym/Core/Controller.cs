using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {

        private EquipmentRepository equipment;

        private List<IGym> gyms;

        public Controller()
        {
            equipment = new EquipmentRepository();

            gyms = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete currentAthleth = null;
            IGym currentGym = gyms.FirstOrDefault(x => x.Name == gymName);

            if (athleteType == "Boxer")
            {
                currentAthleth = new Boxer(athleteName, motivation, numberOfMedals);

            }

            else if (athleteType == "Weightlifter")
            {
                currentAthleth = new Weightlifter(athleteName, motivation, numberOfMedals);

            }
            else
            {
                throw new InvalidOperationException("Invalid athlete type.");

            }

            if (athleteType == "Boxer" && (currentGym == null || currentGym.GetType().Name!= "BoxingGym"))
            {
                return "The gym is not appropriate.";

            }

            if (athleteType == "Weightlifter" && (currentGym == null || currentGym.GetType().Name != "WeightliftingGym"))
            {
                return "The gym is not appropriate.";

            }

            currentGym.AddAthlete(currentAthleth);
            return $"Successfully added {athleteType} to {gymName}.";


        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment newEquipment = null;
            if(equipmentType== "BoxingGloves")
            {
                newEquipment = new BoxingGloves();
            }

            else if(equipmentType== "Kettlebell")
            {

                newEquipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }

            equipment.Add(newEquipment);
            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym = null;

            if (gymType == "BoxingGym")
            {

                gym = new BoxingGym(gymName);
            }

            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);

            }

            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }

            gyms.Add(gym);
            return $"Successfully added {gymType}.";

        }

        public string EquipmentWeight(string gymName)
        {
            throw new NotImplementedException();
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IGym currentGym = gyms.First(x => x.Name == gymName);
            IEquipment currentEquipment = equipment.FindByType(equipmentType);

            if(currentEquipment==null)
            {

                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }
            currentGym.AddEquipment(currentEquipment);
            equipment.Remove(currentEquipment);

            return $"Successfully added {equipmentType} to {gymName}.";

        }

        public string Report()
          
        {
            StringBuilder sba = new StringBuilder();

            foreach (var gym in gyms)
            {
                sba.AppendLine(gym.GymInfo());
            }

            return sba.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            IGym currentGym = gyms.First(x => x.Name == gymName);
            currentGym.Exercise();

            return $"Exercise athletes: {currentGym.Athletes.Count}.";
        }
    }
}
