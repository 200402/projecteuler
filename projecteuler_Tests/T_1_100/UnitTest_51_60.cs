namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_51_60
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_51_test()
        {
            if (tasksList.t_List.Length > 50)
                Assert.That(tasksList.t_List[50].answer(), Is.EqualTo("121313"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_52_test()
        {
            if (tasksList.t_List.Length > 51)
                Assert.That(tasksList.t_List[51].answer(), Is.EqualTo("142857"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_53_test()
        {
            if (tasksList.t_List.Length > 52)
                Assert.That(tasksList.t_List[52].answer(), Is.EqualTo("4075"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_54_test()
        {
            if (tasksList.t_List.Length > 53)
                Assert.That(tasksList.t_List[53].answer(), Is.EqualTo("376"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_55_test()
        {
            if (tasksList.t_List.Length > 54)
                Assert.That(tasksList.t_List[54].answer(), Is.EqualTo("249"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_56_test()
        {
            if (tasksList.t_List.Length > 55)
                Assert.That(tasksList.t_List[55].answer(), Is.EqualTo("972"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_57_test()
        {
            if (tasksList.t_List.Length > 56)
                Assert.That(tasksList.t_List[56].answer(), Is.EqualTo("153"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_58_test()
        {
            if (tasksList.t_List.Length > 57)
                Assert.That(tasksList.t_List[57].answer(), Is.EqualTo("26241"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_59_test()
        {
            if (tasksList.t_List.Length > 58)
                Assert.That(tasksList.t_List[58].answer(), Is.EqualTo("129448"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_60_test()
        {
            if (tasksList.t_List.Length > 59)
                Assert.That(tasksList.t_List[59].answer(), Is.EqualTo("26033"));
            else
                Assert.Ignore();
        }
    }
}
