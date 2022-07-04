namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_331_340
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_331_test()
        {
            if (tasksList.t_List.Length > 330)
                Assert.That(tasksList.t_List[330].answer(), Is.EqualTo("467178235146843549"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_332_test()
        {
            if (tasksList.t_List.Length > 331)
                Assert.That(tasksList.t_List[331].answer(), Is.EqualTo("2717.751525"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_333_test()
        {
            if (tasksList.t_List.Length > 332)
                Assert.That(tasksList.t_List[332].answer(), Is.EqualTo("3053105"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_334_test()
        {
            if (tasksList.t_List.Length > 333)
                Assert.That(tasksList.t_List[333].answer(), Is.EqualTo("150320021261690835"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_335_test()
        {
            if (tasksList.t_List.Length > 334)
                Assert.That(tasksList.t_List[334].answer(), Is.EqualTo("5032316"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_336_test()
        {
            if (tasksList.t_List.Length > 335)
                Assert.That(tasksList.t_List[335].answer(), Is.EqualTo("CAGBIHEFJDK"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_337_test()
        {
            if (tasksList.t_List.Length > 336)
                Assert.That(tasksList.t_List[336].answer(), Is.EqualTo("85068035"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_338_test()
        {
            if (tasksList.t_List.Length > 337)
                Assert.That(tasksList.t_List[337].answer(), Is.EqualTo("15614292"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_339_test()
        {
            if (tasksList.t_List.Length > 338)
                Assert.That(tasksList.t_List[338].answer(), Is.EqualTo("19823.542204"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_340_test()
        {
            if (tasksList.t_List.Length > 339)
                Assert.That(tasksList.t_List[339].answer(), Is.EqualTo("291504964"));
            else
                Assert.Ignore();
        }
    }
}
