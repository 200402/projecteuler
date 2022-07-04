namespace projecteuler_Tests.T_601_700
{
    public class UnitTest_641_650
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_641_test()
        {
            if (tasksList.t_List.Length > 640)
                Assert.That(tasksList.t_List[640].answer(), Is.EqualTo("793525366"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_642_test()
        {
            if (tasksList.t_List.Length > 641)
                Assert.That(tasksList.t_List[641].answer(), Is.EqualTo("631499044"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_643_test()
        {
            if (tasksList.t_List.Length > 642)
                Assert.That(tasksList.t_List[642].answer(), Is.EqualTo("968274154"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_644_test()
        {
            if (tasksList.t_List.Length > 643)
                Assert.That(tasksList.t_List[643].answer(), Is.EqualTo("20.11208767"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_645_test()
        {
            if (tasksList.t_List.Length > 644)
                Assert.That(tasksList.t_List[644].answer(), Is.EqualTo("48894.2174"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_646_test()
        {
            if (tasksList.t_List.Length > 645)
                Assert.That(tasksList.t_List[645].answer(), Is.EqualTo("845218467"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_647_test()
        {
            if (tasksList.t_List.Length > 646)
                Assert.That(tasksList.t_List[646].answer(), Is.EqualTo("563132994232918611"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_648_test()
        {
            if (tasksList.t_List.Length > 647)
                Assert.That(tasksList.t_List[647].answer(), Is.EqualTo("301483197"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_649_test()
        {
            if (tasksList.t_List.Length > 648)
                Assert.That(tasksList.t_List[648].answer(), Is.EqualTo("924668016"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_650_test()
        {
            if (tasksList.t_List.Length > 649)
                Assert.That(tasksList.t_List[649].answer(), Is.EqualTo("538319652"));
            else
                Assert.Ignore();
        }
    }
}
