using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;

namespace SocialNetwork.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UserEntityCreation_IsGood()
        {
            var userRepository = new UserRepository();
            var userEntity = new UserEntity()
            {
                firstname = "Петр",
                lastname = "Петров",
                password = "1029384756",
                email = "hi@gmail.com",
            };
            int result = userRepository.Create(userEntity);
            Assert.NotZero(result);
        }
    }
}