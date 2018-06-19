using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiDI.Services;
using WebApiDI.Models;
using WebApiDI.Controllers;
using WebApiDI.Response;

namespace UnitTestWebApiDi
{
    [TestClass]
    public class UnitTest1
    {
        DbMock _database;
        UserService _userService;
        UsersController _userController;

        [TestInitialize()]
        public void Initialize()
        {
            _database = new DbMock();
            _userService = new UserService(_database);
            _userController = new UsersController(_userService);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            _database = null;
            _userService = null;
            _userService = null;
        }
        [TestMethod]
        public void TestUserCreation_dbLevel()
        {

            // User instance to create and store
            User expected = new User() { Name = "Test", Age = 0 };

            // Store it ... 
            _database.CreateUser(expected);

            // Check stored - placed at index 2
            User actual = _database.GetDataModel()[2];

            // the assertion
            Assert.AreEqual(expected, actual);
                    
        }

        [TestMethod]
        public void TestIntegration_userController_userService_db()
        {
            // Call the userController -> userService -> database
            ResponseModel rm = _userController.Get();

            object actual = rm.Data;
            object expected = _database.GetAllUsers();

            Assert.AreEqual(expected, actual);
        }
    }
}
