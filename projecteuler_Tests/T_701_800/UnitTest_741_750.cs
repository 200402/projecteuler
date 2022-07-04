namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_741_750
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_741_test()
        {
            if (tasksList.t_List.Length > 740)
                Assert.That(tasksList.t_List[740].answer(), Is.EqualTo("512895223"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_742_test()
        {
            if (tasksList.t_List.Length > 741)
                Assert.That(tasksList.t_List[741].answer(), Is.EqualTo("18397727"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_743_test()
        {
            if (tasksList.t_List.Length > 742)
                Assert.That(tasksList.t_List[742].answer(), Is.EqualTo("259158998"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_744_test()
        {
            if (tasksList.t_List.Length > 743)
                Assert.That(tasksList.t_List[743].answer(), Is.EqualTo("0.0001999600"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_745_test()
        {
            if (tasksList.t_List.Length > 744)
                Assert.That(tasksList.t_List[744].answer(), Is.EqualTo("94586478"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_746_test()
        {
            if (tasksList.t_List.Length > 745)
                Assert.That(tasksList.t_List[745].answer(), Is.EqualTo("867150922"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_747_test()
        {
            if (tasksList.t_List.Length > 746)
                Assert.That(tasksList.t_List[746].answer(), Is.EqualTo("681813395"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_748_test()
        {
            if (tasksList.t_List.Length > 747)
                Assert.That(tasksList.t_List[747].answer(), Is.EqualTo("276402862"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_749_test()
        {
            if (tasksList.t_List.Length > 748)
                Assert.That(tasksList.t_List[748].answer(), Is.EqualTo("13459471903176422"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_750_test()
        {
            if (tasksList.t_List.Length > 749)
                Assert.That(tasksList.t_List[749].answer(), Is.EqualTo("160640"));
            else
                Assert.Ignore();
        }
    }
}
