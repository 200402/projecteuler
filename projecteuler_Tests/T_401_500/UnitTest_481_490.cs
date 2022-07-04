namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_481_490
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_481_test()
        {
            if (tasksList.t_List.Length > 480)
                Assert.That(tasksList.t_List[480].answer(), Is.EqualTo("729.12106947"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_482_test()
        {
            if (tasksList.t_List.Length > 481)
                Assert.That(tasksList.t_List[481].answer(), Is.EqualTo("1400824879147"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_483_test()
        {
            if (tasksList.t_List.Length > 482)
                Assert.That(tasksList.t_List[482].answer(), Is.EqualTo("4.993401567e22"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_484_test()
        {
            if (tasksList.t_List.Length > 483)
                Assert.That(tasksList.t_List[483].answer(), Is.EqualTo("8907904768686152599"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_485_test()
        {
            if (tasksList.t_List.Length > 484)
                Assert.That(tasksList.t_List[484].answer(), Is.EqualTo("51281274340"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_486_test()
        {
            if (tasksList.t_List.Length > 485)
                Assert.That(tasksList.t_List[485].answer(), Is.EqualTo("11408450515"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_487_test()
        {
            if (tasksList.t_List.Length > 486)
                Assert.That(tasksList.t_List[486].answer(), Is.EqualTo("106650212746"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_488_test()
        {
            if (tasksList.t_List.Length > 487)
                Assert.That(tasksList.t_List[487].answer(), Is.EqualTo("216737278"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_489_test()
        {
            if (tasksList.t_List.Length > 488)
                Assert.That(tasksList.t_List[488].answer(), Is.EqualTo("1791954757162"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_490_test()
        {
            if (tasksList.t_List.Length > 489)
                Assert.That(tasksList.t_List[489].answer(), Is.EqualTo("777577686"));
            else
                Assert.Ignore();
        }
    }
}
