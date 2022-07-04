namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_361_370
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_361_test()
        {
            if (tasksList.t_List.Length > 360)
                Assert.That(tasksList.t_List[360].answer(), Is.EqualTo("178476944"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_362_test()
        {
            if (tasksList.t_List.Length > 361)
                Assert.That(tasksList.t_List[361].answer(), Is.EqualTo("457895958010"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_363_test()
        {
            if (tasksList.t_List.Length > 362)
                Assert.That(tasksList.t_List[362].answer(), Is.EqualTo("0.0000372091"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_364_test()
        {
            if (tasksList.t_List.Length > 363)
                Assert.That(tasksList.t_List[363].answer(), Is.EqualTo("44855254"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_365_test()
        {
            if (tasksList.t_List.Length > 364)
                Assert.That(tasksList.t_List[364].answer(), Is.EqualTo("162619462356610313"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_366_test()
        {
            if (tasksList.t_List.Length > 365)
                Assert.That(tasksList.t_List[365].answer(), Is.EqualTo("88351299"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_367_test()
        {
            if (tasksList.t_List.Length > 366)
                Assert.That(tasksList.t_List[366].answer(), Is.EqualTo("48271207"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_368_test()
        {
            if (tasksList.t_List.Length > 367)
                Assert.That(tasksList.t_List[367].answer(), Is.EqualTo("253.6135092068"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_369_test()
        {
            if (tasksList.t_List.Length > 368)
                Assert.That(tasksList.t_List[368].answer(), Is.EqualTo("862400558448"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_370_test()
        {
            if (tasksList.t_List.Length > 369)
                Assert.That(tasksList.t_List[369].answer(), Is.EqualTo("41791929448408"));
            else
                Assert.Ignore();
        }
    }
}
