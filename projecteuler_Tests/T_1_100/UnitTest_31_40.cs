namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_31_40
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_31_test()
        {
            if (tasksList.t_List.Length > 30)
                Assert.That(tasksList.t_List[30].answer(), Is.EqualTo("73682"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_32_test()
        {
            if (tasksList.t_List.Length > 31)
                Assert.That(tasksList.t_List[31].answer(), Is.EqualTo("45228"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_33_test()
        {
            if (tasksList.t_List.Length > 32)
                Assert.That(tasksList.t_List[32].answer(), Is.EqualTo("100"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_34_test()
        {
            if (tasksList.t_List.Length > 33)
                Assert.That(tasksList.t_List[33].answer(), Is.EqualTo("40730"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_35_test()
        {
            if (tasksList.t_List.Length > 34)
                Assert.That(tasksList.t_List[34].answer(), Is.EqualTo("55"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_36_test()
        {
            if (tasksList.t_List.Length > 35)
                Assert.That(tasksList.t_List[35].answer(), Is.EqualTo("872187"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_37_test()
        {
            if (tasksList.t_List.Length > 36)
                Assert.That(tasksList.t_List[36].answer(), Is.EqualTo("748317"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_38_test()
        {
            if (tasksList.t_List.Length > 37)
                Assert.That(tasksList.t_List[37].answer(), Is.EqualTo("932718654"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_39_test()
        {
            if (tasksList.t_List.Length > 38)
                Assert.That(tasksList.t_List[38].answer(), Is.EqualTo("840"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_40_test()
        {
            if (tasksList.t_List.Length > 39)
                Assert.That(tasksList.t_List[39].answer(), Is.EqualTo("210"));
            else
                Assert.Ignore();
        }
    }
}
