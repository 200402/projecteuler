namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_581_590
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_581_test()
        {
            if (tasksList.t_List.Length > 580)
                Assert.That(tasksList.t_List[580].answer(), Is.EqualTo("2227616372734"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_582_test()
        {
            if (tasksList.t_List.Length > 581)
                Assert.That(tasksList.t_List[581].answer(), Is.EqualTo("19903"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_583_test()
        {
            if (tasksList.t_List.Length > 582)
                Assert.That(tasksList.t_List[582].answer(), Is.EqualTo("1174137929000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_584_test()
        {
            if (tasksList.t_List.Length > 583)
                Assert.That(tasksList.t_List[583].answer(), Is.EqualTo("32.83822408"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_585_test()
        {
            if (tasksList.t_List.Length > 584)
                Assert.That(tasksList.t_List[584].answer(), Is.EqualTo("17714439395932"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_586_test()
        {
            if (tasksList.t_List.Length > 585)
                Assert.That(tasksList.t_List[585].answer(), Is.EqualTo("82490213"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_587_test()
        {
            if (tasksList.t_List.Length > 586)
                Assert.That(tasksList.t_List[586].answer(), Is.EqualTo("2240"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_588_test()
        {
            if (tasksList.t_List.Length > 587)
                Assert.That(tasksList.t_List[587].answer(), Is.EqualTo("11651930052"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_589_test()
        {
            if (tasksList.t_List.Length > 588)
                Assert.That(tasksList.t_List[588].answer(), Is.EqualTo("131776959.25"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_590_test()
        {
            if (tasksList.t_List.Length > 589)
                Assert.That(tasksList.t_List[589].answer(), Is.EqualTo("834171904"));
            else
                Assert.Ignore();
        }
    }
}
