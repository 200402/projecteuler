namespace projecteuler_Tests.T_701_800
{
    public class UnitTest_701_710
    {
        static TasksList tasksList = new TasksList();

        [Test]
        public void task_701_test()
        {
            if (tasksList.t_List.Length > 700)
                Assert.That(tasksList.t_List[700].answer(), Is.EqualTo("13.51099836"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_702_test()
        {
            if (tasksList.t_List.Length > 701)
                Assert.That(tasksList.t_List[701].answer(), Is.EqualTo("622305608172525546"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_703_test()
        {
            if (tasksList.t_List.Length > 702)
                Assert.That(tasksList.t_List[702].answer(), Is.EqualTo("843437991"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_704_test()
        {
            if (tasksList.t_List.Length > 703)
                Assert.That(tasksList.t_List[703].answer(), Is.EqualTo("501985601490518144"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_705_test()
        {
            if (tasksList.t_List.Length > 704)
                Assert.That(tasksList.t_List[704].answer(), Is.EqualTo("480440153"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_706_test()
        {
            if (tasksList.t_List.Length > 705)
                Assert.That(tasksList.t_List[705].answer(), Is.EqualTo("884837055"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_707_test()
        {
            if (tasksList.t_List.Length > 706)
                Assert.That(tasksList.t_List[706].answer(), Is.EqualTo("652907799"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_708_test()
        {
            if (tasksList.t_List.Length > 707)
                Assert.That(tasksList.t_List[707].answer(), Is.EqualTo("28874142998632109"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_709_test()
        {
            if (tasksList.t_List.Length > 708)
                Assert.That(tasksList.t_List[708].answer(), Is.EqualTo("773479144"));
            else
                Assert.Ignore();
        }

        [Test]
        public void task_710_test()
        {
            if (tasksList.t_List.Length > 709)
                Assert.That(tasksList.t_List[709].answer(), Is.EqualTo("1275000"));
            else
                Assert.Ignore();
        }
    }
}
