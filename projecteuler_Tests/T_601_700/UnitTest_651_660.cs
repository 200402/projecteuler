namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_651_660
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_651_test()
        {
            if (tasksList.t_List.Length > 650)
                Assert.That(tasksList.t_List[650].answer(), Is.EqualTo("448233151"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_652_test()
        {
            if (tasksList.t_List.Length > 651)
                Assert.That(tasksList.t_List[651].answer(), Is.EqualTo("983924497"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_653_test()
        {
            if (tasksList.t_List.Length > 652)
                Assert.That(tasksList.t_List[652].answer(), Is.EqualTo("1130658687"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_654_test()
        {
            if (tasksList.t_List.Length > 653)
                Assert.That(tasksList.t_List[653].answer(), Is.EqualTo("815868280"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_655_test()
        {
            if (tasksList.t_List.Length > 654)
                Assert.That(tasksList.t_List[654].answer(), Is.EqualTo("2000008332"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_656_test()
        {
            if (tasksList.t_List.Length > 655)
                Assert.That(tasksList.t_List[655].answer(), Is.EqualTo("888873503555187"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_657_test()
        {
            if (tasksList.t_List.Length > 656)
                Assert.That(tasksList.t_List[656].answer(), Is.EqualTo("219493139"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_658_test()
        {
            if (tasksList.t_List.Length > 657)
                Assert.That(tasksList.t_List[657].answer(), Is.EqualTo("958280177"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_659_test()
        {
            if (tasksList.t_List.Length > 658)
                Assert.That(tasksList.t_List[658].answer(), Is.EqualTo("238518915714422000"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_660_test()
        {
            if (tasksList.t_List.Length > 659)
                Assert.That(tasksList.t_List[659].answer(), Is.EqualTo("474766783"));
            else
                Assert.Ignore();
        }
    }
}
