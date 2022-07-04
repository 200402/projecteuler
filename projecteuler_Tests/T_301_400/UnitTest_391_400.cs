namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_391_400
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_391_test()
        {
            if (tasksList.t_List.Length > 390)
                Assert.That(tasksList.t_List[390].answer(), Is.EqualTo("61029882288"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_392_test()
        {
            if (tasksList.t_List.Length > 391)
                Assert.That(tasksList.t_List[391].answer(), Is.EqualTo("3.1486734435"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_393_test()
        {
            if (tasksList.t_List.Length > 392)
                Assert.That(tasksList.t_List[392].answer(), Is.EqualTo("112398351350823112"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_394_test()
        {
            if (tasksList.t_List.Length > 393)
                Assert.That(tasksList.t_List[393].answer(), Is.EqualTo("3.2370342194"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_395_test()
        {
            if (tasksList.t_List.Length > 394)
                Assert.That(tasksList.t_List[394].answer(), Is.EqualTo("28.2453753155"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_396_test()
        {
            if (tasksList.t_List.Length > 395)
                Assert.That(tasksList.t_List[395].answer(), Is.EqualTo("173214653"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_397_test()
        {
            if (tasksList.t_List.Length > 396)
                Assert.That(tasksList.t_List[396].answer(), Is.EqualTo("141630459461893728"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_398_test()
        {
            if (tasksList.t_List.Length > 397)
                Assert.That(tasksList.t_List[397].answer(), Is.EqualTo("2010.59096"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_399_test()
        {
            if (tasksList.t_List.Length > 398)
                Assert.That(tasksList.t_List[398].answer(), Is.EqualTo("1508395636674243,6.5e27330467"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_400_test()
        {
            if (tasksList.t_List.Length > 399)
                Assert.That(tasksList.t_List[399].answer(), Is.EqualTo("438505383468410633"));
            else
                Assert.Ignore();
        }
    }
}
