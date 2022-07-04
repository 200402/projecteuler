namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_21_30
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_21_test()
        {
            if (tasksList.t_List.Length > 20)
                Assert.That(tasksList.t_List[20].answer(), Is.EqualTo("31626"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_22_test()
        {
            if (tasksList.t_List.Length > 21)
                Assert.That(tasksList.t_List[21].answer(), Is.EqualTo("871198282"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_23_test()
        {
            if (tasksList.t_List.Length > 22)
                Assert.That(tasksList.t_List[22].answer(), Is.EqualTo("4179871"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_24_test()
        {
            if (tasksList.t_List.Length > 23)
                Assert.That(tasksList.t_List[23].answer(), Is.EqualTo("2783915460"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_25_test()
        {
            if (tasksList.t_List.Length > 24)
                Assert.That(tasksList.t_List[24].answer(), Is.EqualTo("4782"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_26_test()
        {
            if (tasksList.t_List.Length > 25)
                Assert.That(tasksList.t_List[25].answer(), Is.EqualTo("983"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_27_test()
        {
            if (tasksList.t_List.Length > 26)
                Assert.That(tasksList.t_List[26].answer(), Is.EqualTo("-59231"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_28_test()
        {
            if (tasksList.t_List.Length > 27)
                Assert.That(tasksList.t_List[27].answer(), Is.EqualTo("669171001"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_29_test()
        {
            if (tasksList.t_List.Length > 28)
                Assert.That(tasksList.t_List[28].answer(), Is.EqualTo("9183"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_30_test()
        {
            if (tasksList.t_List.Length > 29)
                Assert.That(tasksList.t_List[29].answer(), Is.EqualTo("443839"));
            else
                Assert.Ignore();
        }
    }
}
