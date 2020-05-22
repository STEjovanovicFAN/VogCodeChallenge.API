using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.DatabaseEntities;

namespace VogCodeChallenge.API.Tests
{
    public class TestPlaygroundClass
    {
        public TestPlaygroundClass()
        {
            TestCreateEntities();
        }

        public void TestCreateEntities()
        {

            CreateEntities ce = new CreateEntities();
            var ga = ce.GetAll();

            var la = ce.ListAll();
        }


    }
}
