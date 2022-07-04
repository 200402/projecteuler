namespace projecteuler_Tests.T_301_400
{
    public class UnitTest_371_380
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_371_test()
        {
            if (tasksList.t_List.Length > 370)
                Assert.That(tasksList.t_List[370].answer(), Is.EqualTo("40.66368097"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_372_test()
        {
            if (tasksList.t_List.Length > 371)
                Assert.That(tasksList.t_List[371].answer(), Is.EqualTo("301450082318807027"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_373_test()
        {
            if (tasksList.t_List.Length > 372)
                Assert.That(tasksList.t_List[372].answer(), Is.EqualTo("727227472448913"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_374_test()
        {
            if (tasksList.t_List.Length > 373)
                Assert.That(tasksList.t_List[373].answer(), Is.EqualTo("334420941"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_375_test()
        {
            if (tasksList.t_List.Length > 374)
                Assert.That(tasksList.t_List[374].answer(), Is.EqualTo("7435327983715286168"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_376_test()
        {
            if (tasksList.t_List.Length > 375)
                Assert.That(tasksList.t_List[375].answer(), Is.EqualTo("973059630185670"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_377_test()
        {
            if (tasksList.t_List.Length > 376)
                Assert.That(tasksList.t_List[376].answer(), Is.EqualTo("732385277"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_378_test()
        {
            if (tasksList.t_List.Length > 377)
                Assert.That(tasksList.t_List[377].answer(), Is.EqualTo("147534623725724718"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_379_test()
        {
            if (tasksList.t_List.Length > 378)
                Assert.That(tasksList.t_List[378].answer(), Is.EqualTo("132314136838185"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_380_test()
        {
            if (tasksList.t_List.Length > 379)
                Assert.That(tasksList.t_List[379].answer(), Is.EqualTo("6.3202e25093"));
            else
                Assert.Ignore();
        }
    }
}
