﻿namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cars.Contracts;
    using Cars.Controllers;
    using Cars.Models;
    using Cars.Tests.JustMock.Mocks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
            // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        // Homework
        [TestMethod]
        public void CreateCarsControllerWithoutSpecificRepository()
        {
            var carController = new CarsController();
        }

        [TestMethod]
        public void CreateCarsControllerWithSpecificRepository()
        {
            var carController = new CarsController(this.carsData);
        }

        [TestMethod]
        public void SortingByMarkInAscendingOrder()
        {
            var sortedCarsByMakeModel = (ICollection<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(4, sortedCarsByMakeModel.Count);
            Assert.AreEqual("Audi", sortedCarsByMakeModel.First().Make);
            Assert.AreEqual("BMW", sortedCarsByMakeModel.ElementAt(1).Make);
        }

        [TestMethod]
        public void SortingByYearInAscendigOrder()
        {
            var sortedCarsByYarModel = (ICollection<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(4, sortedCarsByYarModel.Count);
            Assert.AreEqual(2005, sortedCarsByYarModel.First().Year);
            Assert.AreEqual(2007, sortedCarsByYarModel.ElementAt(1).Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingByInvalidProperty()
        {
            var sortedCarsByInvalidPropertyModel = this.controller.Sort("invalid");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SearchingCarsByNoCriteria()
        {
            var matchedCars = this.controller.Search(null);
        }

        [TestMethod]
        public void SearchingCarsByCriteria()
        {
            var matchedCars = (ICollection<Car>)this.GetModel(() => this.controller.Search("Some criteria"));

            Assert.AreEqual(2, matchedCars.Count);
            Assert.AreEqual("BMW", matchedCars.First().Make);
            Assert.AreEqual("BMW", matchedCars.ElementAt(1).Make);
            Assert.AreEqual(2, matchedCars.First().Id);
            Assert.AreEqual(3, matchedCars.ElementAt(1).Id);
        }

        [TestMethod]
        public void GetByIdShouldReturnFirstCar()
        {
            var matchedCars = (Car)this.GetModel(() => this.controller.Details(4));

            Assert.AreEqual("Audi", matchedCars.Make);
            Assert.AreEqual("A5", matchedCars.Model);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetByIdShouldThrowExceptionOnNullCar()
        {
            var matchedCars = (Car)this.GetModel(() => this.controller.Details(0));
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
