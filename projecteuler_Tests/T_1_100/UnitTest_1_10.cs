namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_1_10
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_1_test()
        {
            if (tasksList.t_List.Length > 0)
                Assert.That(tasksList.t_List[0].answer(), Is.EqualTo("233168"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_2_test()
        {
            if (tasksList.t_List.Length > 1)
                Assert.That(tasksList.t_List[1].answer(), Is.EqualTo("4613732"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_3_test()
        {
            if (tasksList.t_List.Length > 2)
                Assert.That(tasksList.t_List[2].answer(), Is.EqualTo("6857"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_4_test()
        {
            if (tasksList.t_List.Length > 3)
                Assert.That(tasksList.t_List[3].answer(), Is.EqualTo("906609"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_5_test()
        {
            if (tasksList.t_List.Length > 4)
                Assert.That(tasksList.t_List[4].answer(), Is.EqualTo("232792560"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_6_test()
        {
            if (tasksList.t_List.Length > 5)
                Assert.That(tasksList.t_List[5].answer(), Is.EqualTo("25164150"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_7_test()
        {
            if (tasksList.t_List.Length > 6)
                Assert.That(tasksList.t_List[6].answer(), Is.EqualTo("104743"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_8_test()
        {
            if (tasksList.t_List.Length > 7)
                Assert.That(tasksList.t_List[7].answer(), Is.EqualTo("23514624000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_9_test()
        {
            if (tasksList.t_List.Length > 8)
                Assert.That(tasksList.t_List[8].answer(), Is.EqualTo("31875000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_10_test()
        {
            if (tasksList.t_List.Length > 9)
                Assert.That(tasksList.t_List[9].answer(), Is.EqualTo("142913828922"));
            else
                Assert.Ignore();
        }
    }
}
