using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private List<IEquipment> equipments;
        private List<IAthlete> athletes;

        public Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            equipments = new List<IEquipment>();
            athletes = new List<IAthlete>();
        }

        public string Name
        {
            get => name;

            set
            {

                if(string.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Gym name cannot be null or empty.");
                }

                name = value;
            }

        }

        public int Capacity { get; set; }

        public double EquipmentWeight => equipments.Sum(x => x.Weight);

        public ICollection<IEquipment> Equipment => equipments;

        public ICollection<IAthlete> Athletes => athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if(athletes.Count==Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");

            }

            athletes.Add(athlete);

        }

        public void AddEquipment(IEquipment equipment)
        {
            equipments.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            StringBuilder sb = new StringBuilder();

            string allAthlethes = string.Join(", ", athletes);

            sb.AppendLine($"{this.Name} is a {GetType().Name}:");
            if(athletes.Count==0)
            {
                sb.AppendLine("Athletes: No athletes");
            }
            else
            {
                sb.AppendLine(allAthlethes);

            }
            sb.AppendLine($"Equipment total count: {equipments.Count}");
            sb.AppendLine($"Equipment total weight: {EquipmentWeight:F2} grams");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
            return athletes.Remove(athlete);
        }
    }
}
