namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_431_440
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_431_test()
        {
            if (tasksList.t_List.Length > 430)
                Assert.That(tasksList.t_List[430].answer(), Is.EqualTo("23.386029052"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_432_test()
        {
            if (tasksList.t_List.Length > 431)
                Assert.That(tasksList.t_List[431].answer(), Is.EqualTo("754862080"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_433_test()
        {
            if (tasksList.t_List.Length > 432)
                Assert.That(tasksList.t_List[432].answer(), Is.EqualTo("326624372659664"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_434_test()
        {
            if (tasksList.t_List.Length > 433)
                Assert.That(tasksList.t_List[433].answer(), Is.EqualTo("863253606"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_435_test()
        {
            if (tasksList.t_List.Length > 434)
                Assert.That(tasksList.t_List[434].answer(), Is.EqualTo("252541322550"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_436_test()
        {
            if (tasksList.t_List.Length > 435)
                Assert.That(tasksList.t_List[435].answer(), Is.EqualTo("0.5276662759"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_437_test()
        {
            if (tasksList.t_List.Length > 436)
                Assert.That(tasksList.t_List[436].answer(), Is.EqualTo("74204709657207"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_438_test()
        {
            if (tasksList.t_List.Length > 437)
                Assert.That(tasksList.t_List[437].answer(), Is.EqualTo("2046409616809"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_439_test()
        {
            if (tasksList.t_List.Length > 438)
                Assert.That(tasksList.t_List[438].answer(), Is.EqualTo("968697378"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_440_test()
        {
            if (tasksList.t_List.Length > 439)
                Assert.That(tasksList.t_List[439].answer(), Is.EqualTo("970746056"));
            else
                Assert.Ignore();
        }
    }
}
