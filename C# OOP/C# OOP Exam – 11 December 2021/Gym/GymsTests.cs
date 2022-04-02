using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]

        public void CtrorGym()
        {

            Gym gym = new Gym("Flex", 500);

            Assert.IsNotNull(gym);
            Assert.AreEqual("Flex", gym.Name);
            Assert.AreEqual(500, gym.Capacity);
        }

        [Test]

        public void CtrorShouldThrowArgumentExeptionforName()
        {

            Assert.Throws<ArgumentNullException>(() => new Gym("", 200));
            Assert.Throws<ArgumentNullException>(() => new Gym(null, 200));
        }


        [Test]

        public void CtrorShouldThrowArgumentExeptionforSize()
        {

            Assert.Throws<ArgumentException>(() => new Gym("Flex", -50));
           
        }

        [Test]
        public void AddAthletheShouldThrowExceptionforCapacity()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");
            Athlete athlete3 = new Athlete("Petar Ivanov");
            Athlete athlete4 = new Athlete("Nikolay Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);

            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(athlete4));
        }
        [Test]
        public void AddAthletheShouldWork()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");
            Athlete athlete3 = new Athlete("Petar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);

            Assert.AreEqual(3, gym.Count);
        }


        [Test]
        public void RemoveAthleteShouldthrowExceptipion()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");
            Athlete athlete3 = new Athlete("Petar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);

            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Zhivko Draganov"));
        }



        [Test]
        public void RemoveAthleteShouldWork()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");
            Athlete athlete3 = new Athlete("Petar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);
            gym.RemoveAthlete("Ivan Ivanov");
            Assert.AreEqual(2, gym.Count);
            
        }


        [Test]
        public void IsInjuredShouldThrowException()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");
            Athlete athlete3 = new Athlete("Petar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);

            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("zlatan ibrahimovich"));

        }


        [Test]
        public void IsInjuredShouldWork()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");
            Athlete athlete3 = new Athlete("Petar Ivanov");
            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);

            Assert.AreEqual(athlete3, gym.InjureAthlete("Petar Ivanov"));

        }

        [Test]
        public void Report()
        {

            Gym gym = new Gym("Flex", 3);
            Athlete athlete1 = new Athlete("Georgi Ivanov");
            Athlete athlete2 = new Athlete("Ivan Ivanov");

            gym.AddAthlete(athlete1);
            gym.AddAthlete(athlete2);

            string report = "Active athletes at Flex: Georgi Ivanov, Ivan Ivanov";

            Assert.AreEqual(report, gym.Report());

        }
    }
}
