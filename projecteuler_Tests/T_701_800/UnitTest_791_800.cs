namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_791_800
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_791_test()
        {
            if (tasksList.t_List.Length > 790)
                Assert.That(tasksList.t_List[790].answer(), Is.EqualTo("404890862"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_792_test()
        {
            if (tasksList.t_List.Length > 791)
                Assert.That(tasksList.t_List[791].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_793_test()
        {
            if (tasksList.t_List.Length > 792)
                Assert.That(tasksList.t_List[792].answer(), Is.EqualTo("475808650131120"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_794_test()
        {
            if (tasksList.t_List.Length > 793)
                Assert.That(tasksList.t_List[793].answer(), Is.EqualTo("8.146681749623"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_795_test()
        {
            if (tasksList.t_List.Length > 794)
                Assert.That(tasksList.t_List[794].answer(), Is.EqualTo("955892601606483"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_796_test()
        {
            if (tasksList.t_List.Length > 795)
                Assert.That(tasksList.t_List[795].answer(), Is.EqualTo("43.20649061"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_797_test()
        {
            if (tasksList.t_List.Length > 796)
                Assert.That(tasksList.t_List[796].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_798_test()
        {
            if (tasksList.t_List.Length > 797)
                Assert.That(tasksList.t_List[797].answer(), Is.EqualTo("nan"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_799_test()
        {
            if (tasksList.t_List.Length > 798)
                Assert.That(tasksList.t_List[798].answer(), Is.EqualTo("1096910149053902"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_800_test()
        {
            if (tasksList.t_List.Length > 799)
                Assert.That(tasksList.t_List[799].answer(), Is.EqualTo("1412403576"));
            else
                Assert.Ignore();
        }
    }
}
