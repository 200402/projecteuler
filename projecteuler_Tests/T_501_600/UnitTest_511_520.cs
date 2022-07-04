namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_511_520
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_511_test()
        {
            if (tasksList.t_List.Length > 510)
                Assert.That(tasksList.t_List[510].answer(), Is.EqualTo("935247012"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_512_test()
        {
            if (tasksList.t_List.Length > 511)
                Assert.That(tasksList.t_List[511].answer(), Is.EqualTo("50660591862310323"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_513_test()
        {
            if (tasksList.t_List.Length > 512)
                Assert.That(tasksList.t_List[512].answer(), Is.EqualTo("2925619196"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_514_test()
        {
            if (tasksList.t_List.Length > 513)
                Assert.That(tasksList.t_List[513].answer(), Is.EqualTo("8986.86698"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_515_test()
        {
            if (tasksList.t_List.Length > 514)
                Assert.That(tasksList.t_List[514].answer(), Is.EqualTo("2422639000800"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_516_test()
        {
            if (tasksList.t_List.Length > 515)
                Assert.That(tasksList.t_List[515].answer(), Is.EqualTo("939087315"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_517_test()
        {
            if (tasksList.t_List.Length > 516)
                Assert.That(tasksList.t_List[516].answer(), Is.EqualTo("581468882"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_518_test()
        {
            if (tasksList.t_List.Length > 517)
                Assert.That(tasksList.t_List[517].answer(), Is.EqualTo("100315739184392"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_519_test()
        {
            if (tasksList.t_List.Length > 518)
                Assert.That(tasksList.t_List[518].answer(), Is.EqualTo("804739330"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_520_test()
        {
            if (tasksList.t_List.Length > 519)
                Assert.That(tasksList.t_List[519].answer(), Is.EqualTo("238413705"));
            else
                Assert.Ignore();
        }
    }
}
