namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_81_90
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_81_test()
        {
            if (tasksList.t_List.Length > 80)
                Assert.That(tasksList.t_List[80].answer(), Is.EqualTo("427337"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_82_test()
        {
            if (tasksList.t_List.Length > 81)
                Assert.That(tasksList.t_List[81].answer(), Is.EqualTo("260324"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_83_test()
        {
            if (tasksList.t_List.Length > 82)
                Assert.That(tasksList.t_List[82].answer(), Is.EqualTo("425185"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_84_test()
        {
            if (tasksList.t_List.Length > 83)
                Assert.That(tasksList.t_List[83].answer(), Is.EqualTo("101524"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_85_test()
        {
            if (tasksList.t_List.Length > 84)
                Assert.That(tasksList.t_List[84].answer(), Is.EqualTo("2772"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_86_test()
        {
            if (tasksList.t_List.Length > 85)
                Assert.That(tasksList.t_List[85].answer(), Is.EqualTo("1818"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_87_test()
        {
            if (tasksList.t_List.Length > 86)
                Assert.That(tasksList.t_List[86].answer(), Is.EqualTo("1097343"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_88_test()
        {
            if (tasksList.t_List.Length > 87)
                Assert.That(tasksList.t_List[87].answer(), Is.EqualTo("7587457"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_89_test()
        {
            if (tasksList.t_List.Length > 88)
                Assert.That(tasksList.t_List[88].answer(), Is.EqualTo("743"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_90_test()
        {
            if (tasksList.t_List.Length > 89)
                Assert.That(tasksList.t_List[89].answer(), Is.EqualTo("1217"));
            else
                Assert.Ignore();
        }
    }
}
