namespace projecteuler_Tests.T_101_200
{
    public class UnitTest_101_110
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_101_test()
        {
            if (tasksList.t_List.Length > 100)
                Assert.That(tasksList.t_List[100].answer(), Is.EqualTo("37076114526"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_102_test()
        {
            if (tasksList.t_List.Length > 101)
                Assert.That(tasksList.t_List[101].answer(), Is.EqualTo("228"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_103_test()
        {
            if (tasksList.t_List.Length > 102)
                Assert.That(tasksList.t_List[102].answer(), Is.EqualTo("20313839404245"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_104_test()
        {
            if (tasksList.t_List.Length > 103)
                Assert.That(tasksList.t_List[103].answer(), Is.EqualTo("329468"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_105_test()
        {
            if (tasksList.t_List.Length > 104)
                Assert.That(tasksList.t_List[104].answer(), Is.EqualTo("73702"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_106_test()
        {
            if (tasksList.t_List.Length > 105)
                Assert.That(tasksList.t_List[105].answer(), Is.EqualTo("21384"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_107_test()
        {
            if (tasksList.t_List.Length > 106)
                Assert.That(tasksList.t_List[106].answer(), Is.EqualTo("259679"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_108_test()
        {
            if (tasksList.t_List.Length > 107)
                Assert.That(tasksList.t_List[107].answer(), Is.EqualTo("180180"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_109_test()
        {
            if (tasksList.t_List.Length > 108)
                Assert.That(tasksList.t_List[108].answer(), Is.EqualTo("38182"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_110_test()
        {
            if (tasksList.t_List.Length > 109)
                Assert.That(tasksList.t_List[109].answer(), Is.EqualTo("9350130049860600"));
            else
                Assert.Ignore();
        }
    }
}
