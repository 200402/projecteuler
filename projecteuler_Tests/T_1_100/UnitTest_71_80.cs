namespace projecteuler_Tests.T_1_100
{
    public class UnitTest_71_80
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_71_test()
        {
            if (tasksList.t_List.Length > 70)
                Assert.That(tasksList.t_List[70].answer(), Is.EqualTo("428570"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_72_test()
        {
            if (tasksList.t_List.Length > 71)
                Assert.That(tasksList.t_List[71].answer(), Is.EqualTo("303963552391"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_73_test()
        {
            if (tasksList.t_List.Length > 72)
                Assert.That(tasksList.t_List[72].answer(), Is.EqualTo("7295372"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_74_test()
        {
            if (tasksList.t_List.Length > 73)
                Assert.That(tasksList.t_List[73].answer(), Is.EqualTo("402"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_75_test()
        {
            if (tasksList.t_List.Length > 74)
                Assert.That(tasksList.t_List[74].answer(), Is.EqualTo("161667"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_76_test()
        {
            if (tasksList.t_List.Length > 75)
                Assert.That(tasksList.t_List[75].answer(), Is.EqualTo("190569291"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_77_test()
        {
            if (tasksList.t_List.Length > 76)
                Assert.That(tasksList.t_List[76].answer(), Is.EqualTo("71"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_78_test()
        {
            if (tasksList.t_List.Length > 77)
                Assert.That(tasksList.t_List[77].answer(), Is.EqualTo("55374"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_79_test()
        {
            if (tasksList.t_List.Length > 78)
                Assert.That(tasksList.t_List[78].answer(), Is.EqualTo("73162890"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_80_test()
        {
            if (tasksList.t_List.Length > 79)
                Assert.That(tasksList.t_List[79].answer(), Is.EqualTo("40886"));
            else
                Assert.Ignore();
        }
    }
}
