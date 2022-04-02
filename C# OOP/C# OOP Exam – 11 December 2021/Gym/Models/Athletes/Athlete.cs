﻿using Gym.Models.Athletes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public abstract class Athlete : IAthlete
    {
        private string fullName;
        private string motivation;
        private int numberOfMedals;

        public Athlete(string fullName, string motivation, int numberOfMedals, int stamina)
        {
            FullName = fullName;
            Motivation = motivation;
            NumberOfMedals = numberOfMedals;
            Stamina = stamina;
        }
        public string FullName
        {
            get => fullName;
            set
            {

                if (string.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Athlete name cannot be null or empty.");
                }
                fullName = value;
            }


        }

        public string Motivation
        {
            get => motivation;

            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The motivation cannot be null or empty.");

                }

                motivation = value;
            }

        }

        public int Stamina { get; set; }

        public int NumberOfMedals
        {
            get=> numberOfMedals;

            set
            {
                if(value<0)
                {
                    throw new ArgumentException("Athlete's number of medals cannot be below 0.");

                }
                numberOfMedals = value;
            }
        }

        public abstract void Exercise();

    }
}
