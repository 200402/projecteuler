namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_711_720
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_711_test()
        {
            if (tasksList.t_List.Length > 710)
                Assert.That(tasksList.t_List[710].answer(), Is.EqualTo("541510990"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_712_test()
        {
            if (tasksList.t_List.Length > 711)
                Assert.That(tasksList.t_List[711].answer(), Is.EqualTo("413876461"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_713_test()
        {
            if (tasksList.t_List.Length > 712)
                Assert.That(tasksList.t_List[712].answer(), Is.EqualTo("788626351539895"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_714_test()
        {
            if (tasksList.t_List.Length > 713)
                Assert.That(tasksList.t_List[713].answer(), Is.EqualTo("2.452767775565e20"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_715_test()
        {
            if (tasksList.t_List.Length > 714)
                Assert.That(tasksList.t_List[714].answer(), Is.EqualTo("883188017"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_716_test()
        {
            if (tasksList.t_List.Length > 715)
                Assert.That(tasksList.t_List[715].answer(), Is.EqualTo("238948623"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_717_test()
        {
            if (tasksList.t_List.Length > 716)
                Assert.That(tasksList.t_List[716].answer(), Is.EqualTo("1603036763131"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_718_test()
        {
            if (tasksList.t_List.Length > 717)
                Assert.That(tasksList.t_List[717].answer(), Is.EqualTo("228579116"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_719_test()
        {
            if (tasksList.t_List.Length > 718)
                Assert.That(tasksList.t_List[718].answer(), Is.EqualTo("128088830547982"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_720_test()
        {
            if (tasksList.t_List.Length > 719)
                Assert.That(tasksList.t_List[719].answer(), Is.EqualTo("688081048"));
            else
                Assert.Ignore();
        }
    }
}
