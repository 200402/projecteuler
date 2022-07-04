namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_141_150
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_141_test()
        {
            if (tasksList.t_List.Length > 140)
                Assert.That(tasksList.t_List[140].answer(), Is.EqualTo("878454337159"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_142_test()
        {
            if (tasksList.t_List.Length > 141)
                Assert.That(tasksList.t_List[141].answer(), Is.EqualTo("1006193"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_143_test()
        {
            if (tasksList.t_List.Length > 142)
                Assert.That(tasksList.t_List[142].answer(), Is.EqualTo("30758397"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_144_test()
        {
            if (tasksList.t_List.Length > 143)
                Assert.That(tasksList.t_List[143].answer(), Is.EqualTo("354"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_145_test()
        {
            if (tasksList.t_List.Length > 144)
                Assert.That(tasksList.t_List[144].answer(), Is.EqualTo("608720"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_146_test()
        {
            if (tasksList.t_List.Length > 145)
                Assert.That(tasksList.t_List[145].answer(), Is.EqualTo("676333270"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_147_test()
        {
            if (tasksList.t_List.Length > 146)
                Assert.That(tasksList.t_List[146].answer(), Is.EqualTo("846910284"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_148_test()
        {
            if (tasksList.t_List.Length > 147)
                Assert.That(tasksList.t_List[147].answer(), Is.EqualTo("2129970655314432"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_149_test()
        {
            if (tasksList.t_List.Length > 148)
                Assert.That(tasksList.t_List[148].answer(), Is.EqualTo("52852124"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_150_test()
        {
            if (tasksList.t_List.Length > 149)
                Assert.That(tasksList.t_List[149].answer(), Is.EqualTo("-271248680"));
            else
                Assert.Ignore();
        }
    }
}
