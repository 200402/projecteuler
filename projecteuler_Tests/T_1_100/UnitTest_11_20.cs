namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_11_20
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_11_test()
        {
            if (tasksList.t_List.Length > 10)
                Assert.That(tasksList.t_List[10].answer(), Is.EqualTo("70600674"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_12_test()
        {
            if (tasksList.t_List.Length > 11)
                Assert.That(tasksList.t_List[11].answer(), Is.EqualTo("76576500"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_13_test()
        {
            Assert.Ignore();
            if (tasksList.t_List.Length > 12)
                Assert.That(tasksList.t_List[12].answer(), Is.EqualTo("5537376230"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_14_test()
        {
            if (tasksList.t_List.Length > 13)
                Assert.That(tasksList.t_List[13].answer(), Is.EqualTo("837799"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_15_test()
        {
            if (tasksList.t_List.Length > 14)
                Assert.That(tasksList.t_List[14].answer(), Is.EqualTo("137846528820"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_16_test()
        {
            if (tasksList.t_List.Length > 15)
                Assert.That(tasksList.t_List[15].answer(), Is.EqualTo("1366"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_17_test()
        {
            if (tasksList.t_List.Length > 16)
                Assert.That(tasksList.t_List[16].answer(), Is.EqualTo("21124"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_18_test()
        {
            if (tasksList.t_List.Length > 17)
                Assert.That(tasksList.t_List[17].answer(), Is.EqualTo("1074"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_19_test()
        {
            if (tasksList.t_List.Length > 18)
                Assert.That(tasksList.t_List[18].answer(), Is.EqualTo("171"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_20_test()
        {
            if (tasksList.t_List.Length > 19)
                Assert.That(tasksList.t_List[19].answer(), Is.EqualTo("648"));
            else
                Assert.Ignore();
        }
    }
}
