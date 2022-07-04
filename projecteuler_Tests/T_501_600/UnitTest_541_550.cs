namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_541_550
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_541_test()
        {
            if (tasksList.t_List.Length > 540)
                Assert.That(tasksList.t_List[540].answer(), Is.EqualTo("4580726482872451"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_542_test()
        {
            if (tasksList.t_List.Length > 541)
                Assert.That(tasksList.t_List[541].answer(), Is.EqualTo("697586734240314852"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_543_test()
        {
            if (tasksList.t_List.Length > 542)
                Assert.That(tasksList.t_List[542].answer(), Is.EqualTo("199007746081234640"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_544_test()
        {
            if (tasksList.t_List.Length > 543)
                Assert.That(tasksList.t_List[543].answer(), Is.EqualTo("640432376"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_545_test()
        {
            if (tasksList.t_List.Length > 544)
                Assert.That(tasksList.t_List[544].answer(), Is.EqualTo("921107572"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_546_test()
        {
            if (tasksList.t_List.Length > 545)
                Assert.That(tasksList.t_List[545].answer(), Is.EqualTo("215656873"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_547_test()
        {
            if (tasksList.t_List.Length > 546)
                Assert.That(tasksList.t_List[546].answer(), Is.EqualTo("11730879.0023"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_548_test()
        {
            if (tasksList.t_List.Length > 547)
                Assert.That(tasksList.t_List[547].answer(), Is.EqualTo("12144044603581281"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_549_test()
        {
            if (tasksList.t_List.Length > 548)
                Assert.That(tasksList.t_List[548].answer(), Is.EqualTo("476001479068717"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_550_test()
        {
            if (tasksList.t_List.Length > 549)
                Assert.That(tasksList.t_List[549].answer(), Is.EqualTo("328104836"));
            else
                Assert.Ignore();
        }
    }
}
