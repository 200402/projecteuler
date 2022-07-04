namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_721_730
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_721_test()
        {
            if (tasksList.t_List.Length > 720)
                Assert.That(tasksList.t_List[720].answer(), Is.EqualTo("700792959"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_722_test()
        {
            if (tasksList.t_List.Length > 721)
                Assert.That(tasksList.t_List[721].answer(), Is.EqualTo("3.376792776502e132"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_723_test()
        {
            if (tasksList.t_List.Length > 722)
                Assert.That(tasksList.t_List[722].answer(), Is.EqualTo("1395793419248"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_724_test()
        {
            if (tasksList.t_List.Length > 723)
                Assert.That(tasksList.t_List[723].answer(), Is.EqualTo("18128250110"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_725_test()
        {
            if (tasksList.t_List.Length > 724)
                Assert.That(tasksList.t_List[724].answer(), Is.EqualTo("4598797036650685"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_726_test()
        {
            if (tasksList.t_List.Length > 725)
                Assert.That(tasksList.t_List[725].answer(), Is.EqualTo("578040951"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_727_test()
        {
            if (tasksList.t_List.Length > 726)
                Assert.That(tasksList.t_List[726].answer(), Is.EqualTo("3.64039141"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_728_test()
        {
            if (tasksList.t_List.Length > 727)
                Assert.That(tasksList.t_List[727].answer(), Is.EqualTo("709874991"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_729_test()
        {
            if (tasksList.t_List.Length > 728)
                Assert.That(tasksList.t_List[728].answer(), Is.EqualTo("308896374.2502"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_730_test()
        {
            if (tasksList.t_List.Length > 729)
                Assert.That(tasksList.t_List[729].answer(), Is.EqualTo("1315965924"));
            else
                Assert.Ignore();
        }
    }
}
