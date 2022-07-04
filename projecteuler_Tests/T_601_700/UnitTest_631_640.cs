namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_631_640
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_631_test()
        {
            if (tasksList.t_List.Length > 630)
                Assert.That(tasksList.t_List[630].answer(), Is.EqualTo("869588692"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_632_test()
        {
            if (tasksList.t_List.Length > 631)
                Assert.That(tasksList.t_List[631].answer(), Is.EqualTo("728378714"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_633_test()
        {
            if (tasksList.t_List.Length > 632)
                Assert.That(tasksList.t_List[632].answer(), Is.EqualTo("1.0012e-10"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_634_test()
        {
            if (tasksList.t_List.Length > 633)
                Assert.That(tasksList.t_List[633].answer(), Is.EqualTo("4019680944"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_635_test()
        {
            if (tasksList.t_List.Length > 634)
                Assert.That(tasksList.t_List[634].answer(), Is.EqualTo("689294705"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_636_test()
        {
            if (tasksList.t_List.Length > 635)
                Assert.That(tasksList.t_List[635].answer(), Is.EqualTo("888316"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_637_test()
        {
            if (tasksList.t_List.Length > 636)
                Assert.That(tasksList.t_List[636].answer(), Is.EqualTo("49000634845039"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_638_test()
        {
            if (tasksList.t_List.Length > 637)
                Assert.That(tasksList.t_List[637].answer(), Is.EqualTo("18423394"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_639_test()
        {
            if (tasksList.t_List.Length > 638)
                Assert.That(tasksList.t_List[638].answer(), Is.EqualTo("797866893"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_640_test()
        {
            if (tasksList.t_List.Length > 639)
                Assert.That(tasksList.t_List[639].answer(), Is.EqualTo("50.317928"));
            else
                Assert.Ignore();
        }
    }
}
