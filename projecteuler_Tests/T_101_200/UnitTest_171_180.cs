namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_171_180
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_171_test()
        {
            if (tasksList.t_List.Length > 170)
                Assert.That(tasksList.t_List[170].answer(), Is.EqualTo("142989277"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_172_test()
        {
            if (tasksList.t_List.Length > 171)
                Assert.That(tasksList.t_List[171].answer(), Is.EqualTo("227485267000992000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_173_test()
        {
            if (tasksList.t_List.Length > 172)
                Assert.That(tasksList.t_List[172].answer(), Is.EqualTo("1572729"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_174_test()
        {
            if (tasksList.t_List.Length > 173)
                Assert.That(tasksList.t_List[173].answer(), Is.EqualTo("209566"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_175_test()
        {
            if (tasksList.t_List.Length > 174)
                Assert.That(tasksList.t_List[174].answer(), Is.EqualTo("1,13717420,8"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_176_test()
        {
            if (tasksList.t_List.Length > 175)
                Assert.That(tasksList.t_List[175].answer(), Is.EqualTo("96818198400000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_177_test()
        {
            if (tasksList.t_List.Length > 176)
                Assert.That(tasksList.t_List[176].answer(), Is.EqualTo("129325"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_178_test()
        {
            if (tasksList.t_List.Length > 177)
                Assert.That(tasksList.t_List[177].answer(), Is.EqualTo("126461847755"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_179_test()
        {
            if (tasksList.t_List.Length > 178)
                Assert.That(tasksList.t_List[178].answer(), Is.EqualTo("986262"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_180_test()
        {
            if (tasksList.t_List.Length > 179)
                Assert.That(tasksList.t_List[179].answer(), Is.EqualTo("285196020571078987"));
            else
                Assert.Ignore();
        }
    }
}
