namespace projecteuler_Tests.T_501_600
{
    public class UnitTest_551_560
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_551_test()
        {
            if (tasksList.t_List.Length > 550)
                Assert.That(tasksList.t_List[550].answer(), Is.EqualTo("73597483551591773"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_552_test()
        {
            if (tasksList.t_List.Length > 551)
                Assert.That(tasksList.t_List[551].answer(), Is.EqualTo("326227335"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_553_test()
        {
            if (tasksList.t_List.Length > 552)
                Assert.That(tasksList.t_List[552].answer(), Is.EqualTo("57717170"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_554_test()
        {
            if (tasksList.t_List.Length > 553)
                Assert.That(tasksList.t_List[553].answer(), Is.EqualTo("89539872"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_555_test()
        {
            if (tasksList.t_List.Length > 554)
                Assert.That(tasksList.t_List[554].answer(), Is.EqualTo("208517717451208352"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_556_test()
        {
            if (tasksList.t_List.Length > 555)
                Assert.That(tasksList.t_List[555].answer(), Is.EqualTo("52126939292957"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_557_test()
        {
            if (tasksList.t_List.Length > 556)
                Assert.That(tasksList.t_List[556].answer(), Is.EqualTo("2699929328"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_558_test()
        {
            if (tasksList.t_List.Length > 557)
                Assert.That(tasksList.t_List[557].answer(), Is.EqualTo("226754889"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_559_test()
        {
            if (tasksList.t_List.Length > 558)
                Assert.That(tasksList.t_List[558].answer(), Is.EqualTo("684724920"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_560_test()
        {
            if (tasksList.t_List.Length > 559)
                Assert.That(tasksList.t_List[559].answer(), Is.EqualTo("994345168"));
            else
                Assert.Ignore();
        }
    }
}
