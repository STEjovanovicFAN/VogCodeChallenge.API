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
            TestMod();
        }

        public void TestMod()
        {
            var oneAmount = TESTModule.Module(1);
            var doubleAmount = TESTModule.Module(2);
            var doubleAmount2 = TESTModule.Module(2.0);

            var tripleAmount = TESTModule.Module(3);

            var floatAmount = TESTModule.Module(1.0f);
            var floatAmount2 = TESTModule.Module(1.0000000000f);
            var floatAmount3 = TESTModule.Module(1.0000001f);

            //float amount4 should not return 0, use double instead of float in the TESTModule code for more accurate results
            var floatAmount4 = TESTModule.Module(1.00000001f);

        }


        public void TestCreateEntities()
        {

            CreateEntities ce = new CreateEntities();
            var ga = ce.GetAll();

            var la = ce.ListAll();
        }


    }
}
