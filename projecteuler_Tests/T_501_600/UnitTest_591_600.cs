namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_591_600
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_591_test()
        {
            if (tasksList.t_List.Length > 590)
                Assert.That(tasksList.t_List[590].answer(), Is.EqualTo("526007984625966"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_592_test()
        {
            if (tasksList.t_List.Length > 591)
                Assert.That(tasksList.t_List[591].answer(), Is.EqualTo("13415DF2BE9C"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_593_test()
        {
            if (tasksList.t_List.Length > 592)
                Assert.That(tasksList.t_List[592].answer(), Is.EqualTo("96632320042.0"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_594_test()
        {
            if (tasksList.t_List.Length > 593)
                Assert.That(tasksList.t_List[593].answer(), Is.EqualTo("47067598"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_595_test()
        {
            if (tasksList.t_List.Length > 594)
                Assert.That(tasksList.t_List[594].answer(), Is.EqualTo("54.17529329"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_596_test()
        {
            if (tasksList.t_List.Length > 595)
                Assert.That(tasksList.t_List[595].answer(), Is.EqualTo("734582049"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_597_test()
        {
            if (tasksList.t_List.Length > 596)
                Assert.That(tasksList.t_List[596].answer(), Is.EqualTo("0.5001817828"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_598_test()
        {
            if (tasksList.t_List.Length > 597)
                Assert.That(tasksList.t_List[597].answer(), Is.EqualTo("543194779059"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_599_test()
        {
            if (tasksList.t_List.Length > 598)
                Assert.That(tasksList.t_List[598].answer(), Is.EqualTo("12395526079546335"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_600_test()
        {
            if (tasksList.t_List.Length > 599)
                Assert.That(tasksList.t_List[599].answer(), Is.EqualTo("2668608479740672"));
            else
                Assert.Ignore();
        }
    }
}
