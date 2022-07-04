namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_421_430
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_421_test()
        {
            if (tasksList.t_List.Length > 420)
                Assert.That(tasksList.t_List[420].answer(), Is.EqualTo("2304215802083466198"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_422_test()
        {
            if (tasksList.t_List.Length > 421)
                Assert.That(tasksList.t_List[421].answer(), Is.EqualTo("92060460"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_423_test()
        {
            if (tasksList.t_List.Length > 422)
                Assert.That(tasksList.t_List[422].answer(), Is.EqualTo("653972374"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_424_test()
        {
            if (tasksList.t_List.Length > 423)
                Assert.That(tasksList.t_List[423].answer(), Is.EqualTo("1059760019628"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_425_test()
        {
            if (tasksList.t_List.Length > 424)
                Assert.That(tasksList.t_List[424].answer(), Is.EqualTo("46479497324"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_426_test()
        {
            if (tasksList.t_List.Length > 425)
                Assert.That(tasksList.t_List[425].answer(), Is.EqualTo("31591886008"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_427_test()
        {
            if (tasksList.t_List.Length > 426)
                Assert.That(tasksList.t_List[426].answer(), Is.EqualTo("97138867"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_428_test()
        {
            if (tasksList.t_List.Length > 427)
                Assert.That(tasksList.t_List[427].answer(), Is.EqualTo("747215561862"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_429_test()
        {
            if (tasksList.t_List.Length > 428)
                Assert.That(tasksList.t_List[428].answer(), Is.EqualTo("98792821"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_430_test()
        {
            if (tasksList.t_List.Length > 429)
                Assert.That(tasksList.t_List[429].answer(), Is.EqualTo("5000624921.38"));
            else
                Assert.Ignore();
        }
    }
}
