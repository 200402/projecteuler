namespace projecteuler_Tests.T_401_500
{
    public class UnitTest_461_470
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_461_test()
        {
            if (tasksList.t_List.Length > 460)
                Assert.That(tasksList.t_List[460].answer(), Is.EqualTo("159820276"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_462_test()
        {
            if (tasksList.t_List.Length > 461)
                Assert.That(tasksList.t_List[461].answer(), Is.EqualTo("5.5350769703e1512"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_463_test()
        {
            if (tasksList.t_List.Length > 462)
                Assert.That(tasksList.t_List[462].answer(), Is.EqualTo("808981553"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_464_test()
        {
            if (tasksList.t_List.Length > 463)
                Assert.That(tasksList.t_List[463].answer(), Is.EqualTo("198775297232878"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_465_test()
        {
            if (tasksList.t_List.Length > 464)
                Assert.That(tasksList.t_List[464].answer(), Is.EqualTo("585965659"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_466_test()
        {
            if (tasksList.t_List.Length > 465)
                Assert.That(tasksList.t_List[465].answer(), Is.EqualTo("258381958195474745"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_467_test()
        {
            if (tasksList.t_List.Length > 466)
                Assert.That(tasksList.t_List[466].answer(), Is.EqualTo("775181359"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_468_test()
        {
            if (tasksList.t_List.Length > 467)
                Assert.That(tasksList.t_List[467].answer(), Is.EqualTo("852950321"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_469_test()
        {
            if (tasksList.t_List.Length > 468)
                Assert.That(tasksList.t_List[468].answer(), Is.EqualTo("0.56766764161831"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_470_test()
        {
            if (tasksList.t_List.Length > 469)
                Assert.That(tasksList.t_List[469].answer(), Is.EqualTo("147668794"));
            else
                Assert.Ignore();
        }
    }
}
